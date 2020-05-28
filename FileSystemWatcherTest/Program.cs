using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using CommandLine;
using CommandLine.Text;
using System.Diagnostics;

namespace FileSystemWatcher
{
    class Options
    {
        [Option('f', "filter", DefaultValue = "*.txt",
          HelpText = "Filter to be processed.")]
        public string Filter { get; set; }

        [Option('s', "sound", DefaultValue = "Exclamation",
          HelpText = "Type of songs.")]
        public string Sound { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }

    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            var options = new Options();

            if (!CommandLine.Parser.Default.ParseArguments(args, options)) return;

            Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + System.Reflection.Assembly.GetEntryAssembly().FullName + " started. Press <Enter> to exit...");

            // Создаем объект наблюдателя
            System.IO.FileSystemWatcher file_watcher = new System.IO.FileSystemWatcher
            {
                Path = AppDomain.CurrentDomain.BaseDirectory,

                // Будем следить за измненениями по последнему доступу, времени записи и переименованию файла или директорий
                NotifyFilter = NotifyFilters.LastWrite,

                // Указываем что следить надо только за определенными файлами
                Filter = options.Filter
            };

            // Добавляем обработчики событий
            file_watcher.Changed += 
                new FileSystemEventHandler(OnFilsStateChanged);

            // Включаем наблюдение
            file_watcher.EnableRaisingEvents = true;

            Console.Read();
            
        }

        /// <summary>
        /// обработчик события изменения
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private static void OnFilsStateChanged(object source,
                           FileSystemEventArgs e)
        {
            if (e.Name == "Предупреждение.txt")
            {
                Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] File: " + e.Name + " " + e.ChangeType + ".");
                SystemSounds.Exclamation.Play();
            }
            if (e.Name == "Звездочка.txt")
            {
                Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] File: " + e.Name + " " + e.ChangeType + ".");
                SystemSounds.Asterisk.Play();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace FileWatcherTray
{
    public partial class MainForm : Form
    {
        private static System.Media.SoundPlayer SPlayer;

        private static void OnFilsStateChanged(object source,
                           FileSystemEventArgs e)
        {
            if (e.Name.ToUpper() == "ПРЕДУПРЕЖДЕНИЕ.TXT" || e.Name.ToUpper() == "EXCLAMATION.TXT")
            {
                //SystemSounds.Exclamation.Play();
                PlayResources(Properties.Resources.WavExclamation);

            }
            if (e.Name.ToUpper() == "ЗВЕЗДОЧКА.TXT" || e.Name.ToUpper() == "ASTERISK.TXT")
            {
                //SystemSounds.Asterisk.Play();
                PlayResources(Properties.Resources.WavAsterisk);
            }
            if (e.Name.ToUpper() == "ГУДОК.TXT" || e.Name.ToUpper() == "BEEP.TXT")
            {
                //SystemSounds.Beep.Play();
                PlayResources(Properties.Resources.WavBeep);
            }
        }

        public MainForm()
        {
            InitializeComponent();

            SPlayer = new System.Media.SoundPlayer();

            System.IO.FileSystemWatcher file_watcher = new System.IO.FileSystemWatcher
            {
                // Будем следить за измненениями времени записи текстовых файлов в текущей директории
                Path = AppDomain.CurrentDomain.BaseDirectory,
                NotifyFilter = NotifyFilters.LastWrite,
                Filter = "*.txt"
            };

            file_watcher.Changed +=
                new FileSystemEventHandler(OnFilsStateChanged);
            file_watcher.EnableRaisingEvents = true;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Reflection.Assembly.GetEntryAssembly().FullName + Environment.NewLine + Environment.OSVersion,
                            "About " + Application.ProductName + "...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private static void PlayResources(Stream stream)
        {
            SPlayer.Stream = stream;
            SPlayer.Play();
        }

        private void ToolStripMenuItemBeep_Click(object sender, EventArgs e)
        {
            PlayResources(Properties.Resources.WavBeep);
        }

        private void ToolStripMenuItemAsterisk_Click(object sender, EventArgs e)
        {
            PlayResources(Properties.Resources.WavAsterisk);
        }

        private void ToolStripMenuItemExclamation_Click(object sender, EventArgs e)
        {
            PlayResources(Properties.Resources.WavExclamation);
        }
    }
}

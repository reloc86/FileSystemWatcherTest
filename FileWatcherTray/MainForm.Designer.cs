namespace FileWatcherTray
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTestSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExclamation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAsterisk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBeep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ZEON FileWatcherTray (DblClick to exit)";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuIcon
            // 
            this.contextMenuIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTestSound,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
            this.contextMenuIcon.Name = "contextMenuIcon";
            this.contextMenuIcon.Size = new System.Drawing.Size(132, 82);
            // 
            // toolStripMenuItemTestSound
            // 
            this.toolStripMenuItemTestSound.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExclamation,
            this.toolStripMenuItemAsterisk,
            this.toolStripMenuItemBeep});
            this.toolStripMenuItemTestSound.Name = "toolStripMenuItemTestSound";
            this.toolStripMenuItemTestSound.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItemTestSound.Text = "Test sound";
            // 
            // toolStripMenuItemExclamation
            // 
            this.toolStripMenuItemExclamation.Name = "toolStripMenuItemExclamation";
            this.toolStripMenuItemExclamation.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemExclamation.Text = "Exclamation";
            this.toolStripMenuItemExclamation.Click += new System.EventHandler(this.ToolStripMenuItemExclamation_Click);
            // 
            // toolStripMenuItemAsterisk
            // 
            this.toolStripMenuItemAsterisk.Name = "toolStripMenuItemAsterisk";
            this.toolStripMenuItemAsterisk.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemAsterisk.Text = "Asterisk";
            this.toolStripMenuItemAsterisk.Click += new System.EventHandler(this.ToolStripMenuItemAsterisk_Click);
            // 
            // toolStripMenuItemBeep
            // 
            this.toolStripMenuItemBeep.Name = "toolStripMenuItemBeep";
            this.toolStripMenuItemBeep.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemBeep.Text = "Beep";
            this.toolStripMenuItemBeep.Click += new System.EventHandler(this.ToolStripMenuItemBeep_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.contextMenuIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTestSound;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExclamation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAsterisk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBeep;
    }
}


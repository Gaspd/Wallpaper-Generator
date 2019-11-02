namespace Wallpaper_Generator
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Display = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.TextBox();
            this.Quit = new System.Windows.Forms.Button();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitNotify = new System.Windows.Forms.ToolStripMenuItem();
            this.Start = new System.Windows.Forms.Button();
            this.Czas = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SetCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Display, "Display");
            this.Display.Name = "Display";
            this.Display.TabStop = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            // 
            // Quit
            // 
            resources.ApplyResources(this.Quit, "Quit");
            this.Quit.Name = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Notify
            // 
            this.Notify.ContextMenuStrip = this.NotifyMenu;
            resources.ApplyResources(this.Notify, "Notify");
            this.Notify.Click += new System.EventHandler(this.Notify_Click);
            this.Notify.DoubleClick += new System.EventHandler(this.Notify_DoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.QuitNotify});
            this.NotifyMenu.Name = "NotifyMenu";
            resources.ApplyResources(this.NotifyMenu, "NotifyMenu");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // QuitNotify
            // 
            this.QuitNotify.Name = "QuitNotify";
            resources.ApplyResources(this.QuitNotify, "QuitNotify");
            this.QuitNotify.Click += new System.EventHandler(this.QuitNotify_Click);
            // 
            // Start
            // 
            resources.ApplyResources(this.Start, "Start");
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Czas
            // 
            this.Czas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Czas, "Czas");
            this.Czas.Items.AddRange(new object[] {
            resources.GetString("Czas.Items"),
            resources.GetString("Czas.Items1"),
            resources.GetString("Czas.Items2"),
            resources.GetString("Czas.Items3"),
            resources.GetString("Czas.Items4"),
            resources.GetString("Czas.Items5")});
            this.Czas.Name = "Czas";
            // 
            // SetCheck
            // 
            resources.ApplyResources(this.SetCheck, "SetCheck");
            this.SetCheck.Name = "SetCheck";
            this.SetCheck.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.SetCheck);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Display);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem QuitNotify;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox Czas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox SetCheck;
    }
}


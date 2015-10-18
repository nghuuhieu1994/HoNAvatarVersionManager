namespace HoNFreeAvatar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_folderPath = new System.Windows.Forms.TextBox();
            this.pb_Process = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_count = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOldFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superBetaTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_folderPath
            // 
            this.tb_folderPath.Location = new System.Drawing.Point(337, 15);
            this.tb_folderPath.Name = "tb_folderPath";
            this.tb_folderPath.Size = new System.Drawing.Size(435, 20);
            this.tb_folderPath.TabIndex = 1;
            this.tb_folderPath.TextChanged += new System.EventHandler(this.tb_folderPath_TextChanged);
            // 
            // pb_Process
            // 
            this.pb_Process.Location = new System.Drawing.Point(13, 395);
            this.pb_Process.Name = "pb_Process";
            this.pb_Process.Size = new System.Drawing.Size(759, 10);
            this.pb_Process.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 307);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(13, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 316);
            this.panel2.TabIndex = 10;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(24, 53);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(93, 13);
            this.lb_count.TabIndex = 0;
            this.lb_count.Text = "Number of Avatar:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.settingToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.deleteOldFilesToolStripMenuItem,
            this.loadMenuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Visible = false;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loadToolStripMenuItem.Text = "Convert";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // deleteOldFilesToolStripMenuItem
            // 
            this.deleteOldFilesToolStripMenuItem.Name = "deleteOldFilesToolStripMenuItem";
            this.deleteOldFilesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteOldFilesToolStripMenuItem.Text = "Delete Old Files";
            this.deleteOldFilesToolStripMenuItem.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // loadMenuToolStripMenuItem
            // 
            this.loadMenuToolStripMenuItem.Name = "loadMenuToolStripMenuItem";
            this.loadMenuToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loadMenuToolStripMenuItem.Text = "Load Menu";
            this.loadMenuToolStripMenuItem.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToolStripMenuItem,
            this.garenaToolStripMenuItem,
            this.superBetaTestToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.settingToolStripMenuItem.Text = "Update";
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pathToolStripMenuItem.Text = "Soon Beta Test";
            this.pathToolStripMenuItem.Click += new System.EventHandler(this.pathToolStripMenuItem_Click);
            // 
            // garenaToolStripMenuItem
            // 
            this.garenaToolStripMenuItem.Name = "garenaToolStripMenuItem";
            this.garenaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.garenaToolStripMenuItem.Text = "Garena";
            this.garenaToolStripMenuItem.Click += new System.EventHandler(this.garenaToolStripMenuItem_Click);
            // 
            // superBetaTestToolStripMenuItem
            // 
            this.superBetaTestToolStripMenuItem.Name = "superBetaTestToolStripMenuItem";
            this.superBetaTestToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.superBetaTestToolStripMenuItem.Text = "Super Beta Test";
            this.superBetaTestToolStripMenuItem.Click += new System.EventHandler(this.superBetaTestToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem1
            // 
            this.settingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToolStripMenuItem1});
            this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
            this.settingToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem1.Text = "Setting";
            // 
            // pathToolStripMenuItem1
            // 
            this.pathToolStripMenuItem1.Name = "pathToolStripMenuItem1";
            this.pathToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.pathToolStripMenuItem1.Text = "Path";
            this.pathToolStripMenuItem1.Click += new System.EventHandler(this.pathToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(164, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 316);
            this.panel1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(600, 307);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Process);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_folderPath);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_folderPath;
        private System.Windows.Forms.ProgressBar pb_Process;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOldFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem superBetaTestToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}


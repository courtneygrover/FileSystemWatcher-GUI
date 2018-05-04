namespace FSWGUI
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStartButt = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStopButt = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripStartButt = new System.Windows.Forms.ToolStripButton();
            this.toolStripStopButt = new System.Windows.Forms.ToolStripButton();
            this.toolStripWriteButt = new System.Windows.Forms.ToolStripButton();
            this.toolStripQueryButt = new System.Windows.Forms.ToolStripButton();
            this.mainInputPanel = new System.Windows.Forms.Panel();
            this.clearButt = new System.Windows.Forms.Button();
            this.queryButt = new System.Windows.Forms.Button();
            this.writeButt = new System.Windows.Forms.Button();
            this.browseButt = new System.Windows.Forms.Button();
            this.submitButt = new System.Windows.Forms.Button();
            this.stopButt = new System.Windows.Forms.Button();
            this.startButt = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.watcher = new System.IO.FileSystemWatcher();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1092, 42);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStartButt,
            this.fileStopButt,
            this.queryDatabaseToolStripMenuItem,
            this.writeToDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileStartButt
            // 
            this.fileStartButt.Name = "fileStartButt";
            this.fileStartButt.Size = new System.Drawing.Size(306, 38);
            this.fileStartButt.Text = "Start";
            this.fileStartButt.Click += new System.EventHandler(this.fileStartButt_Click);
            // 
            // fileStopButt
            // 
            this.fileStopButt.Name = "fileStopButt";
            this.fileStopButt.Size = new System.Drawing.Size(306, 38);
            this.fileStopButt.Text = "Stop";
            this.fileStopButt.Click += new System.EventHandler(this.fileStopButt_Click);
            // 
            // queryDatabaseToolStripMenuItem
            // 
            this.queryDatabaseToolStripMenuItem.Name = "queryDatabaseToolStripMenuItem";
            this.queryDatabaseToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.queryDatabaseToolStripMenuItem.Text = "Query Database";
            this.queryDatabaseToolStripMenuItem.Click += new System.EventHandler(this.queryDatabaseToolStripMenuItem_Click);
            // 
            // writeToDatabaseToolStripMenuItem
            // 
            this.writeToDatabaseToolStripMenuItem.Name = "writeToDatabaseToolStripMenuItem";
            this.writeToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.writeToDatabaseToolStripMenuItem.Text = "Write to Database";
            this.writeToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.writeToDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStartButt,
            this.toolStripStopButt,
            this.toolStripWriteButt,
            this.toolStripQueryButt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1092, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripStartButt
            // 
            this.toolStripStartButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStartButt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStartButt.Image")));
            this.toolStripStartButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStartButt.Name = "toolStripStartButt";
            this.toolStripStartButt.Size = new System.Drawing.Size(36, 36);
            this.toolStripStartButt.Text = "Start FileSystemWatcher";
            this.toolStripStartButt.Click += new System.EventHandler(this.toolStripStartButt_Click);
            // 
            // toolStripStopButt
            // 
            this.toolStripStopButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStopButt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStopButt.Image")));
            this.toolStripStopButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStopButt.Name = "toolStripStopButt";
            this.toolStripStopButt.Size = new System.Drawing.Size(36, 36);
            this.toolStripStopButt.Text = "Stop FileSystemWatcher";
            this.toolStripStopButt.Click += new System.EventHandler(this.toolStripStopButt_Click);
            // 
            // toolStripWriteButt
            // 
            this.toolStripWriteButt.Checked = true;
            this.toolStripWriteButt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripWriteButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripWriteButt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripWriteButt.Image")));
            this.toolStripWriteButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripWriteButt.Name = "toolStripWriteButt";
            this.toolStripWriteButt.Size = new System.Drawing.Size(36, 36);
            this.toolStripWriteButt.Text = "toolStripButton1";
            this.toolStripWriteButt.Click += new System.EventHandler(this.toolStripWriteButt_Click);
            // 
            // toolStripQueryButt
            // 
            this.toolStripQueryButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripQueryButt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripQueryButt.Image")));
            this.toolStripQueryButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripQueryButt.Name = "toolStripQueryButt";
            this.toolStripQueryButt.Size = new System.Drawing.Size(36, 36);
            this.toolStripQueryButt.Text = "Query Database";
            this.toolStripQueryButt.Click += new System.EventHandler(this.toolStripQueryButt_Click);
            // 
            // mainInputPanel
            // 
            this.mainInputPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainInputPanel.Controls.Add(this.clearButt);
            this.mainInputPanel.Controls.Add(this.queryButt);
            this.mainInputPanel.Controls.Add(this.writeButt);
            this.mainInputPanel.Controls.Add(this.browseButt);
            this.mainInputPanel.Controls.Add(this.submitButt);
            this.mainInputPanel.Controls.Add(this.stopButt);
            this.mainInputPanel.Controls.Add(this.startButt);
            this.mainInputPanel.Controls.Add(this.pathTextBox);
            this.mainInputPanel.Controls.Add(this.extensionComboBox);
            this.mainInputPanel.Controls.Add(this.extensionLabel);
            this.mainInputPanel.Controls.Add(this.pathLabel);
            this.mainInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainInputPanel.Location = new System.Drawing.Point(0, 81);
            this.mainInputPanel.Name = "mainInputPanel";
            this.mainInputPanel.Size = new System.Drawing.Size(1092, 203);
            this.mainInputPanel.TabIndex = 2;
            // 
            // clearButt
            // 
            this.clearButt.AutoSize = true;
            this.clearButt.Location = new System.Drawing.Point(892, 43);
            this.clearButt.Name = "clearButt";
            this.clearButt.Size = new System.Drawing.Size(171, 35);
            this.clearButt.TabIndex = 10;
            this.clearButt.Text = "Clear Database";
            this.clearButt.UseVisualStyleBackColor = true;
            this.clearButt.Click += new System.EventHandler(this.clearButt_Click);
            // 
            // queryButt
            // 
            this.queryButt.AutoSize = true;
            this.queryButt.Location = new System.Drawing.Point(885, 93);
            this.queryButt.Name = "queryButt";
            this.queryButt.Size = new System.Drawing.Size(178, 35);
            this.queryButt.TabIndex = 9;
            this.queryButt.Text = "Query Database";
            this.queryButt.UseVisualStyleBackColor = true;
            this.queryButt.Click += new System.EventHandler(this.queryButt_Click);
            // 
            // writeButt
            // 
            this.writeButt.AutoSize = true;
            this.writeButt.Location = new System.Drawing.Point(862, 143);
            this.writeButt.Name = "writeButt";
            this.writeButt.Size = new System.Drawing.Size(201, 35);
            this.writeButt.TabIndex = 8;
            this.writeButt.Text = "Write to Database";
            this.writeButt.UseVisualStyleBackColor = true;
            this.writeButt.Click += new System.EventHandler(this.writeButt_Click);
            // 
            // browseButt
            // 
            this.browseButt.AutoSize = true;
            this.browseButt.Location = new System.Drawing.Point(705, 26);
            this.browseButt.Name = "browseButt";
            this.browseButt.Size = new System.Drawing.Size(111, 35);
            this.browseButt.TabIndex = 7;
            this.browseButt.Text = "Browse...";
            this.browseButt.UseVisualStyleBackColor = true;
            this.browseButt.Click += new System.EventHandler(this.browseButt_Click);
            // 
            // submitButt
            // 
            this.submitButt.AutoSize = true;
            this.submitButt.Location = new System.Drawing.Point(143, 143);
            this.submitButt.Name = "submitButt";
            this.submitButt.Size = new System.Drawing.Size(119, 36);
            this.submitButt.TabIndex = 6;
            this.submitButt.Text = "Submit";
            this.submitButt.UseVisualStyleBackColor = true;
            this.submitButt.Click += new System.EventHandler(this.submitButt_Click);
            // 
            // stopButt
            // 
            this.stopButt.AutoSize = true;
            this.stopButt.Location = new System.Drawing.Point(568, 143);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(119, 36);
            this.stopButt.TabIndex = 5;
            this.stopButt.Text = "Stop";
            this.stopButt.UseVisualStyleBackColor = true;
            this.stopButt.Click += new System.EventHandler(this.stopButt_Click);
            // 
            // startButt
            // 
            this.startButt.AutoSize = true;
            this.startButt.Location = new System.Drawing.Point(431, 144);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(119, 36);
            this.startButt.TabIndex = 4;
            this.startButt.Text = "Start";
            this.startButt.UseVisualStyleBackColor = true;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(143, 28);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(544, 31);
            this.pathTextBox.TabIndex = 3;
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".doc",
            ".docx",
            ".jpg",
            ".pdf",
            ".png",
            ".txt"});
            this.extensionComboBox.Location = new System.Drawing.Point(143, 70);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(159, 33);
            this.extensionComboBox.TabIndex = 2;
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(24, 73);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(113, 25);
            this.extensionLabel.TabIndex = 1;
            this.extensionLabel.Text = "Extension:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(24, 28);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(74, 25);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "PATH:";
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.AllowUserToAddRows = false;
            this.mainDataGrid.AllowUserToDeleteRows = false;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGrid.Location = new System.Drawing.Point(0, 284);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.ReadOnly = true;
            this.mainDataGrid.RowTemplate.Height = 33;
            this.mainDataGrid.Size = new System.Drawing.Size(1092, 445);
            this.mainDataGrid.TabIndex = 3;
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess)));
            this.watcher.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 729);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.mainInputPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MainForm";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainInputPanel.ResumeLayout(false);
            this.mainInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileStartButt;
        private System.Windows.Forms.ToolStripMenuItem fileStopButt;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripStartButt;
        private System.Windows.Forms.ToolStripButton toolStripStopButt;
        private System.Windows.Forms.ToolStripButton toolStripQueryButt;
        private System.Windows.Forms.Panel mainInputPanel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Button submitButt;
        private System.Windows.Forms.Button stopButt;
        private System.Windows.Forms.Button startButt;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button browseButt;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.ToolStripButton toolStripWriteButt;
        private System.Windows.Forms.Button queryButt;
        private System.Windows.Forms.Button writeButt;
        private System.Windows.Forms.Button clearButt;
        private System.Windows.Forms.ToolStripMenuItem writeToDatabaseToolStripMenuItem;
    }
}


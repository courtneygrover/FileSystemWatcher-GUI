namespace FSWGUI
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.queryDataGrid = new System.Windows.Forms.DataGridView();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // queryDataGrid
            // 
            this.queryDataGrid.AllowUserToAddRows = false;
            this.queryDataGrid.AllowUserToDeleteRows = false;
            this.queryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.queryDataGrid.Location = new System.Drawing.Point(0, 116);
            this.queryDataGrid.Name = "queryDataGrid";
            this.queryDataGrid.ReadOnly = true;
            this.queryDataGrid.RowTemplate.Height = 33;
            this.queryDataGrid.Size = new System.Drawing.Size(1092, 513);
            this.queryDataGrid.TabIndex = 0;
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
            this.extensionComboBox.Location = new System.Drawing.Point(168, 37);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(121, 33);
            this.extensionComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extension:";
            // 
            // submitButt
            // 
            this.submitButt.AutoSize = true;
            this.submitButt.Location = new System.Drawing.Point(320, 37);
            this.submitButt.Name = "submitButt";
            this.submitButt.Size = new System.Drawing.Size(88, 35);
            this.submitButt.TabIndex = 3;
            this.submitButt.Text = "Submit";
            this.submitButt.UseVisualStyleBackColor = true;
            this.submitButt.Click += new System.EventHandler(this.submitButt_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 629);
            this.Controls.Add(this.submitButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.queryDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryForm";
            this.Text = "Query Database";
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView queryDataGrid;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButt;
    }
}
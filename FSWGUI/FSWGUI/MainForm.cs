using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FSWGUI
{
    public partial class MainForm : Form
    {
        public SQLiteConnection sql_con;
        public SQLiteCommand sql_cmd;

        public MainForm()
        {
            InitializeComponent();

            startButt.Enabled = false;
            toolStripStartButt.Enabled = false;
            fileStartButt.Enabled = false;

            stopButt.Enabled = false;
            toolStripStopButt.Enabled = false;
            fileStopButt.Enabled = false;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnChanged);
            watcher.EnableRaisingEvents = false;

            mainDataGrid.Columns.Add("ext", "Extension");
            mainDataGrid.Columns.Add("fname", "File Name");
            mainDataGrid.Columns.Add("path", "PATH");
            mainDataGrid.Columns.Add("evt", "Event");
            mainDataGrid.Columns.Add("dt", "Date/Time");

            //change width of each column by index
            mainDataGrid.Columns[0].Width = 60;
            mainDataGrid.Columns[2].Width = 130;
            mainDataGrid.Columns[3].Width = 85;
            mainDataGrid.Columns[4].Width = 125;

            sql_con = new SQLiteConnection("Data Source=FSWDB.db");
            createTable();
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            string extension = Path.GetExtension(e.FullPath);
            if (extension == "")
                extension = "directory";
            this.mainDataGrid.Rows.Add(extension, Path.GetFileName(e.FullPath), Path.GetDirectoryName(e.FullPath).Replace("\\", "/"), e.ChangeType, DateTime.Now);

        }//end OnChanged

        private void createTable()
        {
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Events (Extension varchar(10), Filename varchar(100), PATH varchar(255), Event varchar(100), DateTime varchar(100));";
            sql_cmd.ExecuteNonQuery();

            sql_con.Close();
        }

        private void writeCommandsToDatabase()
        {
            if (this.mainDataGrid.Rows.Count != 0)
            {
                createTable();
                this.sql_con.Open();
                this.sql_cmd = this.sql_con.CreateCommand();
                System.Text.StringBuilder vals = new System.Text.StringBuilder();

                foreach (DataGridViewRow row in mainDataGrid.Rows)
                {
                    vals.Append("('");
                    vals.Append(row.Cells["ext"].Value.ToString() + "', '");
                    vals.Append(row.Cells["fname"].Value.ToString() + "', '");
                    vals.Append(row.Cells["path"].Value.ToString() + "', '");
                    vals.Append(row.Cells["evt"].Value.ToString() + "', '");
                    vals.Append(row.Cells["dt"].Value.ToString() + "')");

                    this.sql_cmd.CommandText = "INSERT INTO Events VALUES" + vals.ToString();
                    this.sql_cmd.ExecuteNonQuery();
                    vals.Clear();
                }

                this.mainDataGrid.Rows.Clear();
                this.mainDataGrid.Refresh();
                this.sql_con.Close();
            }
            else
            {
                MessageBox.Show("Nothing to write to Database!");
            }
        }

        private void browseButt_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog(); // Show the dialog.
            pathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void submitButt_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pathTextBox.Text))
            {
                submitButt.Enabled = false;
                pathTextBox.Enabled = false;
                extensionComboBox.Enabled = false;
                browseButt.Enabled = false;

                startButt.Enabled = true;
                toolStripStartButt.Enabled = true;
                fileStartButt.Enabled = true;

            }
            else
                MessageBox.Show("The specified PATH does not exist.");
        }

        private void startButt_Click(object sender, EventArgs e)
        {
            startButt.Enabled = false;
            toolStripStartButt.Enabled = false;
            fileStartButt.Enabled = false;

            stopButt.Enabled = true;
            toolStripStopButt.Enabled = true;
            fileStopButt.Enabled = true;

            watcher.Path = pathTextBox.Text;
            watcher.Filter = "*" + extensionComboBox.Text;
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
        }

        private void stopButt_Click(object sender, EventArgs e)
        {
            stopButt.Enabled = false;
            toolStripStopButt.Enabled = false;
            fileStopButt.Enabled = false;

            startButt.Enabled = false;
            toolStripStartButt.Enabled = false;
            fileStartButt.Enabled = false;

            submitButt.Enabled = true;
            pathTextBox.Enabled = true;
            extensionComboBox.Enabled = true;

            watcher.EnableRaisingEvents = false;
        }

        private void writeToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeCommandsToDatabase();
        }

        private void queryButt_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void toolStripStartButt_Click(object sender, EventArgs e)
        {
            startButt_Click(sender, e);
        }

        private void fileStartButt_Click(object sender, EventArgs e)
        {
            startButt_Click(sender, e);
        }

        private void toolStripStopButt_Click(object sender, EventArgs e)
        {
            stopButt_Click(sender, e);
        }

        private void fileStopButt_Click(object sender, EventArgs e)
        {
            stopButt_Click(sender, e);
        }

        private void writeButt_Click(object sender, EventArgs e)
        {
            writeCommandsToDatabase();
        }

        private void toolStripWriteButt_Click(object sender, EventArgs e)
        {
            writeCommandsToDatabase();
        }

        private void toolStripQueryButt_Click(object sender, EventArgs e)
        {
            queryButt_Click(sender, e);
        }

        private void queryDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryButt_Click(sender, e);
        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "DROP TABLE Events;";
            sql_cmd.ExecuteNonQuery();

            sql_con.Close();
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (mainDataGrid.Rows.Count != 0)
            {
                if (MessageBox.Show("Write to Database before closing?", "File System Watcher", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    writeCommandsToDatabase();
            }
        }

    }//end partial class

}//end namespace

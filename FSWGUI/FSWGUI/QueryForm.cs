using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace FSWGUI
{
    public partial class QueryForm : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter dataAdapter;

        public QueryForm()
        {
            InitializeComponent();
        }

        private void submitButt_Click(object sender, EventArgs e)
        {
            sql_con = new SQLiteConnection("Data Source=FSWDB.db");

            createTable();

            DataSet dataSet = new DataSet();

            if(extensionComboBox.Text == "")
                dataAdapter = new SQLiteDataAdapter("SELECT * FROM Events", sql_con);
            else
                dataAdapter = new SQLiteDataAdapter("SELECT * FROM Events WHERE Extension = '" + extensionComboBox.Text +"'", sql_con);

            dataAdapter.Fill(dataSet);

            queryDataGrid.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void createTable()
        {
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Events (Extension varchar(10), Filename varchar(100), PATH varchar(255), Event varchar(100), DateTime varchar(100));";
            sql_cmd.ExecuteNonQuery();

            sql_con.Close();
        }
    }
}

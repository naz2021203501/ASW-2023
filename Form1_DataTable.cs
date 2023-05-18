using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "/test.db");
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "CREATE TABLE IF NOT EXISTS test (" +
                    "id INTEGER PRIMARY KEY, " +
                    "schedule TEXT NOT NULL, " +
                    "date TEXT NOT NULL)";
                command.ExecuteNonQuery();

                command.CommandText = "INSERT OR IGNORE INTO test (id, schedule, date) VALUES (1, 'assignment', '2023-05-15')," +
                    "(2, 'project', '2023-05-17')," +
                    "(3, 'meeting', '2023-05-23')";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM test";
                SQLiteDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
                dataReader.Close();

                dataGridView1.Columns[0].HeaderText = "아이디";
                dataGridView1.Columns[1].HeaderText = "일정";
                dataGridView1.Columns[2].HeaderText = "날짜";

                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        
    }
}

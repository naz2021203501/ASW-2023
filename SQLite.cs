using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Numerics;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Security.Policy;

namespace project
{
    public class SQLite
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;

        public SQLite()
        {
            connect_db(@"Data Source=C:\Users\진\source\repos\ASW-2023gj\DB\AWS.db");
        }
        // DB 연결 및 연결 끊기
        public void connect_db(string path)
        {
            string strConn = path;
            con = new SQLiteConnection(strConn);
            con.Open();
        }
        public void disconnect_db()
        {
            con.Close();
        }
        // DB 조작 - create, read, insert, delete
        public void create_table(string table_name, string attribute) //해당 이름의 테이블을 새로 생성할 것
        {
            string query = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{table_name}';";
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                query = $"CREATE TABLE {table_name}({attribute});";
                cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
        public SQLiteDataReader read_table(string table_name)
        {
            string query = $"SELECT * FROM {table_name};";
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader read_select(string table_name, string attribute)
        {
            string query = $"SELECT {attribute} FROM {table_name};";
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader read_where(string table_name, string condition)
        {
            string query = $"SELECT * FROM {table_name} WHERE {condition};";
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader read_select_where(string table_name, string attribute, string condition)
        {
            string query = $"SELECT {attribute} FROM {table_name} WHERE {condition};";
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public void delete_data(string table_name, string date)
        {
            string query = $"DELETE FROM {table_name} WHERE date = '{date}';";
            cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        public void update_table(string table_name, string attribute)
        {
            string query = $"INSERT INTO {table_name} VALUES ({attribute});";
            cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        // DB의 user table의 정보 - log in, sign in에서 사용
        public DataTable get_user()
        {
            SQLiteDataReader reader = read_table("user");
            DataTable userTable = new DataTable();
            userTable.Columns.Add("Name", typeof(string));
            userTable.Columns.Add("DOB", typeof(string));
            userTable.Columns.Add("SEX", typeof(bool));
            userTable.Columns.Add("EMAIL", typeof(string));
            userTable.Columns.Add("PH", typeof(string));

            userTable.Columns.Add("ID", typeof(string));
            userTable.Columns.Add("PW", typeof(string));
            while (reader.Read())
            {
                string u_name = reader.GetString(0);
                string u_dob = reader.GetString(1);
                bool u_sex = Convert.ToBoolean(reader.GetInt32(2));
                string u_email = reader.GetString(3);
                string u_ph = reader.GetString(4);

                string u_id = reader.GetString(5);
                string u_pw = reader.GetString(6);

                userTable.Rows.Add(u_name, u_dob, u_sex, u_email, u_ph, u_id, u_pw);
            }
            return userTable;
        }
        public Dictionary<string, string> get_IdandPw()
        {
            Dictionary<string, string> find_IdandPq = new Dictionary<string, string>();

            SQLiteDataReader reader = read_select("user", "ID, PW");
            while (reader.Read())
            {
                string u_id = reader[0].ToString();
                string u_pw = reader[1].ToString();

                find_IdandPq[u_id] = u_pw;
            }
            return find_IdandPq;
        }
        // DB의 해당 user의 schedule, income, outcome의 정보
        public DataTable get_schedule(string table_name, string date)
        {
            SQLiteDataReader reader = read_where(table_name, $"date='{date}'");
            DataTable schedulers = new DataTable();
            schedulers.Columns.Add("Date", typeof(string));
            schedulers.Columns.Add("Schedule", typeof(string));
            schedulers.Columns.Add("Done", typeof(bool));
            while (reader.Read())
            {
                string s_date = reader.GetString(0);
                string s_schedule = reader.GetString(1);
                int tmp = reader.GetInt32(2);
                bool s_done = true;
                if (tmp == 0) { s_done = false; }
                else { s_done = true; }

                schedulers.Rows.Add(s_date, s_schedule, s_done);
            }
            return schedulers;
        }
        public DataTable get_budget(string table_name, string date)
        {
            SQLiteDataReader reader = read_where(table_name, $"date='{date}'");
            DataTable budgets = new DataTable();
            budgets.Columns.Add("Date", typeof(string));
            budgets.Columns.Add("Category", typeof(string));
            budgets.Columns.Add("Description", typeof(string));
            budgets.Columns.Add("Amount", typeof(Int32));
            while (reader.Read())
            {
                string b_date = reader.GetString(0);
                string b_category = reader.GetString(1);
                string b_description = reader.GetString(2);
                int b_amount = reader.GetInt32(3);

                budgets.Rows.Add(b_date, b_category, b_description, b_amount);
            }
            return budgets;
        }
        public void add_user(string u_name, string u_dob, bool u_sex, string u_email, string u_ph, string u_id, string u_pw)
        {
            string table_name = "user";
            string attribute = $"'{u_name}', '{u_dob}', '{u_sex.ToString()}', '{u_email}', '{u_ph}', '{u_id}', '{u_pw}'";
            update_table(table_name, attribute);
        }
        public void add_schedule(string table_name, string date, string description, int done)
        {
            string attribute = $"'{date}', '{description}', '{done}'";
            update_table(table_name, attribute);
        }
        public void add_budget(string table_name, string date, string newCategory, string newDescription, int newAmount)
        {
            string attribute = $"'{date}', '{newCategory}', '{newDescription}', '{newAmount}'";
            update_table(table_name, attribute);
        }
    }
}
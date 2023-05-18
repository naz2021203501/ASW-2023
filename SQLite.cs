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

namespace project
{
    public class User
    {
        private string name;
        private string dob;
        private bool sex;
        private string email;
        private string ph;

        private string id;
        private string pw;

        public User(string name, string dob, bool sex, string email, string ph, string id, string pw)
        {
            this.name = name;
            this.dob = dob;
            this.sex = sex;
            this.email = email;
            this.ph = ph;
            this.id = id;
            this.pw = pw;
        }

        public string get_id()
        {
            return this.id;
        }

        public string get_pw()
        {
            return this.pw;
        }
    }
    public class Scheduler
    {
        private string date;
        private string schedule;
        private bool done;

        public Scheduler(string date, string schedule, bool done)
        {
            this.date = date;
            this.schedule = schedule;
            this.done = done;
        }
        public void modify_date(string date)
        {
            this.date = date;
        }
        public void modify_schedule(string schedule)
        {
            this.schedule = schedule;
        }
        public void modify_done()
        {
            done = !done;
        }

        public string get_date() { return date; }
        public string get_schedule() { return schedule; }
        public bool get_done() { return done; }
    }
    public class Budget
    {
        private string date;
        private string description;
        private int amount;

        public Budget(string date, string description, int amount)
        {
            this.date = date;
            this.description = description;
            this.amount = amount;
        }

        public string get_date() { return date; }
        public string get_description() { return description; }
        public int get_amount() { return amount; }
    }
    public class SQLite
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;

        public SQLite()
        {
            connect_db(@"Data Source=C:\Users\sjmra\Desktop\Visual Studio\응용소프트웨어실습\project\DB\AWS.db");
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
            Console.WriteLine(query);
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public DataTable read_adapt(string table_name)
        {
            string query = $"SELECT * FROM {table_name};";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con);

            DataTable table = new DataTable(table_name);
            table.Columns.Add("Name");
            table.Columns.Add("Day of Birthday");
            table.Columns.Add("Sex");
            table.Columns.Add("Email");
            table.Columns.Add("Phone Number");
            table.Columns.Add("ID");
            table.Columns.Add("PW");

            return table;
        }
        public void update_table(string table_name, string attribute)
        {
            string query = $"INSERT INTO {table_name} VALUES ({attribute});";
            cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        // DB의 user table의 정보 - log in, sign in에서 사용
        public List<User> get_user()
        {
            SQLiteDataReader reader = read_table("user");
            List<User> user = new List<User>();
            while (reader.Read())
            {
                string u_name = reader.GetString(0);
                string u_dob = reader.GetString(1);
                bool u_sex = reader.GetBoolean(2);
                string u_email = reader.GetString(3);
                string u_ph = reader.GetString(4);

                string u_id = reader.GetString(5);
                string u_pw = reader.GetString(6);

                User u = new User(u_name, u_dob, u_sex, u_email, u_ph, u_id, u_pw);
                Console.WriteLine(u_name, u_dob, u_sex, u_email, u_ph, u_id, u_pw);
                user.Add(u);
            }
            return user;
        }
        public void add_user(string u_name, string u_dob, bool u_sex, string u_email, string u_ph, string u_id, string u_pw)
        {
            string table_name = "user";
            string attribute = $"'{u_name}', '{u_dob}', '{u_sex.ToString()}', '{u_email}', '{u_ph}', '{u_id}', '{u_pw}'";
            update_table(table_name, attribute);
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
        public List<Scheduler> get_schedule(string table_name, string date)
        {
            SQLiteDataReader reader = read_where(table_name, $"date='{date}'");
            List < Scheduler > schedulers = new List<Scheduler>();
            while(reader.Read())
            {
                string s_date = reader.GetString(0);
                string s_schedule = reader.GetString(1);
                bool s_done = reader.GetBoolean(2);

                Scheduler s = new Scheduler(s_date, s_schedule, s_done);
                schedulers.Add(s);

                Console.WriteLine(reader.ToString());
            }
            return schedulers ;
        }
        public List<Budget> get_budget(string table_name, string date)
        {
            SQLiteDataReader reader = read_where(table_name, $"date='{date}'");
            List<Budget> budgets = new List<Budget>();
            while (reader.Read())
            {
                string b_date = reader.GetString(0);
                string b_description = reader.GetString(1);
                int b_amount = reader.GetInt32(2);

                Budget b = new Budget(b_date, b_description, b_amount);
                budgets.Add(b);
            }
            return budgets;
        }
    }
}
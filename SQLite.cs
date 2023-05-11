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

namespace project
{
    public class User
    {
        private string name;
        private DateTime dob;
        private bool sex;
        private string email;
        private string ph;

        private string id;
        private string pw;

        public User(string name, DateTime dob, bool sex, string email, string ph, string id, string pw)
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

    public class SQLite
    {
        private SQLiteConnection con;
        private User[] user = new User[100];
        
        public void connect_db()
        {
            string strConn = @"Data Source=C:\Users\sjmra\Desktop\Visual Studio\응용소프트웨어실습\project\DB\AWS.db";
            con = new SQLiteConnection(strConn);
            con.Open();
        }

        public void disconnect_db()
        {
            con.Close();
        }

        public User[] get_user()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM user", con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string u_name = reader[0].ToString();
                DateTime u_dob = Convert.ToDateTime(reader[1]);
                bool u_sex = Convert.ToBoolean(reader[2]);
                string u_email = reader[3].ToString();
                string u_ph = reader[4].ToString();

                string u_id = reader[5].ToString();
                string u_pw = reader[6].ToString();

                User u = new User(u_name, u_dob, u_sex, u_email, u_ph, u_id, u_pw);
                user.Append(u);
            }
            return user;
        }

        public void add_user(string u_name, DateTime u_dob, bool u_sex, string u_email, string u_ph, string u_id, string u_pw)
        {
            string sqlUser = "INSERT INTO user VALUES ('";
            sqlUser += u_name + "', '";
            sqlUser += u_dob.ToString() + "', '";
            sqlUser += u_sex.ToString() + "', '";
            sqlUser += u_email + "', '";
            sqlUser += u_ph + "', '";
            sqlUser += u_id + "', '";
            sqlUser += u_pw + "');";

            SQLiteCommand command = new SQLiteCommand(sqlUser, con);
            command.ExecuteNonQuery();
        }

        public Dictionary<string, string> get_IdandPw()
        {
            Dictionary<string, string> find_IdandPq = new Dictionary<string, string>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT ID, PW FROM user", con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string u_id = reader[0].ToString();
                string u_pw = reader[1].ToString();

                find_IdandPq[u_id] = u_pw;
            }
            return find_IdandPq;
        }

        public SQLite() {
            connect_db();
        }
    }
}
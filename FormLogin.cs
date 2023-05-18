using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormLogin : Form
    {
        private SQLite userSql = new SQLite();
        private Dictionary<string, string> info;

        public FormLogin()
        {
            InitializeComponent();
            txtId.Text = string.Empty;
            txtPw.Text = string.Empty;
            info = userSql.get_IdandPw();
        }

        public Dictionary<string, string> get_info()
        {
            return info;
        }

        public bool match_info(string key, string value)
        {
            bool find = false;
            foreach(string id  in info.Keys)
            {
                if(key == id && info[key] == value)
                {
                    find = true;
                    return find;
                }
            }
            return find;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string pw = txtPw.Text;

            if (match_info(id, pw))
            {
                FormMain main = new FormMain(id, userSql);
                main.Show();
                // 해당 ID를 이름으로 한 스케줄러 테이블과 가계부 테이블을 가져와서
                // main form 에 넘겨주기
                // 서지민이라는 이름을 가진 테이블의 정보를 가져오기
                // DB -> list, ... 자료구조 형태로 바꿔서 저장, 변경, ...
            }
            else
            {
                MessageBox.Show("아이디/비밀번호를 찾을 수 없습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void signin_close(object sender, FormClosedEventArgs e)
        {
            info = userSql.get_IdandPw();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FormSignin signin = new FormSignin(this);
            signin.Show();
            signin.FormClosed += signin_close;
        }
    }
}

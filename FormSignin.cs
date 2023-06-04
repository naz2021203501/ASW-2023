using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace project
{
    public partial class FormSignin : Form
    {
        private SQLite userSql = new SQLite();
        FormLogin login;
        private Dictionary<string, string> info;
        private bool is_unique = false;
        private bool is_same = false;
        public FormSignin(FormLogin log_in)
        {
            InitializeComponent();
            login = log_in;
            info = login.get_info();

            rdoMale.Checked = true;
            
            int year_size = DateTime.Now.Year - 1900+1;
            string[] year = new string[year_size];
            for (int i=1900; i<=DateTime.Now.Year; i++)
            {
                year[i-1900]=i.ToString();
            }

            cmbYear.DataSource = year;
            cmbYear.SelectedIndex = 0;
            
            string[] month = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    month[i - 1] = "0" + i.ToString();
                }
                else
                {
                    month[i - 1] = i.ToString();
                }
            }
            cmbMonth.DataSource = month;
            cmbMonth.SelectedIndex = 0;

            string[] date = new string[31];
            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                {
                    date[i - 1] = "0" + i.ToString();
                }
                else
                {
                    date[i - 1] = i.ToString();
                }
                
            }
            cmbDate.Items.AddRange(date);
            cmbDate.SelectedIndex = 0;
        }
        private void btnUsable_Click(object sender, EventArgs e)
        {
            bool is_exist = false;

            foreach(string id in info.Keys)
            {
                if (txtId.Text == id)
                {
                    is_exist = true;
                    MessageBox.Show("이미 존재하는 아이디 입니다", "아이디 중복", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId.Text = string.Empty;
                    break;
                }
            }
            if (txtId.Text != string.Empty && !is_exist)
            {
                is_unique = true;
                MessageBox.Show("사용가능한 아이디 입니다", "아이디 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            is_unique = false;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != string.Empty && txtCheckPw.Text != string.Empty)
            {
                if (txtPw.Text == txtCheckPw.Text)
                {
                    is_same = true;
                    MessageBox.Show("비밀번호가 일치합니다!", "비밀번호 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    is_same = false;
                    MessageBox.Show("비밀번호를 확인하세요", "비밀번호 확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (btnVisible.Text == "Visible")
            {
                txtPw.PasswordChar = '\0';
                txtCheckPw.PasswordChar = '\0';
                btnVisible.Text = "Invisible";
            }
            else if (btnVisible.Text == "Invisible")
            {
                txtPw.PasswordChar = '*';
                txtCheckPw.PasswordChar = '*';
                btnVisible.Text = "Visible";
            }
        }
        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            is_unique = false;
        }
        private void txtCheckPw_TextChanged(object sender, EventArgs e)
        {
            is_unique = false;
        }
        public bool check_ID()
        {
            return is_unique;
        }
        public bool check_PW()
        {
            return is_same;
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            string u_name = txtName.Text;
            string u_dob = cmbYear.Text+"-"+cmbMonth.Text+"-"+cmbDate.Text;
            bool u_sex = true;
            if (rdoMale.Checked) {
                u_sex = true;
            }
            else
            {
                u_sex = false;
            }
            string u_email = txtEmail.Text;
            string u_ph = txtPH1.Text + "-" + txtPH2.Text + "-" + txtPH3.Text;

            string u_id = txtId.Text;
            string u_pw = txtPw.Text;

            if (check_ID() && check_PW())
            {
                userSql.add_user(u_name, u_dob, u_sex, u_email, u_ph, u_id, u_pw);
                Close();
            }
            else
            {
                if (is_unique == false)
                {
                    MessageBox.Show("사용가능한 아이디인지 확인해주세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(is_same == false)
                {
                    MessageBox.Show("비밀번호를 확인해주세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("빈칸 없이 모두 입력하세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }
    }
}

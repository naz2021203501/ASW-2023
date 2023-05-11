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

            cmbYear.Items.AddRange(year);
            cmbYear.SelectedIndex = 0;
            
            string[] month = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                month[i-1] = i.ToString();
            }
            cmbMonth.Items.AddRange(month);
            cmbMonth.SelectedIndex = 0;

            string[] date = new string[31];
            for (int i = 1; i <= 31; i++)
            {
                date[i - 1] = i.ToString();
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
        private void txtCheckPw_Enter(object sender, EventArgs e)
        {
            if(txtPw.Text == txtCheckPw.Text)
            {
                is_same = true;
            }
            else
            {
                MessageBox.Show("비밀번호를 확인하세요", "비밀번호 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            DateTime u_dob = Convert.ToDateTime(cmbYear.Text+"-"+cmbMonth.Text+"-"+cmbDate.Text);
            Console.WriteLine(u_dob);
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

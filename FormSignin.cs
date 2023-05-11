using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project
{
    public partial class FormSignin : Form
    {
        private SQLite userSql = new SQLite();
        public FormSignin()
        {
            InitializeComponent();
            FormLogin login = (FormLogin)this.Owner;
            
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

            if (txtPw.Text == txtCheckPw.Text)
            {
                userSql.add_user(u_name, u_dob, u_sex, u_email, u_ph, u_id, u_pw);
                Close();
            }
            else
            {
                MessageBox.Show("빈칸 없이 모두 입력하세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class FormBudget : Form
    {
        FormMain main;
        DataTable I_table;
        DataTable O_table;
        string date;
        public FormBudget(FormMain total_main, DataTable I_table, DataTable O_table, string date)
        {
            main = total_main;
            InitializeComponent();

            this.I_table = I_table;
            this.O_table = O_table;
            this.date = date;
            label3.Text = date;

            dgv_income.Rows.Clear();
            dgv_income.DataSource = I_table;

            dgv_outcome.Rows.Clear();
            dgv_outcome.DataSource = O_table;

        }

        private void a_btn_Click(object sender, EventArgs e)
        {
            string tmp1 = txtD.Text;
            string tmp2 = txtA.Text;
            if (!string.IsNullOrEmpty(tmp1)|| !string.IsNullOrEmpty(tmp2))
            {
                if (income_btn.Checked) {
                    DataRow newRow = I_table.NewRow();
                    newRow["Date"] = date; newRow["Description"] = tmp1; newRow["Amount"] = tmp2;
                    I_table.Rows.Add(newRow);
                }
                else if (outcome_btn.Checked) {
                    DataRow newRow = O_table.NewRow();
                    newRow["Date"] = date; newRow["Description"] = tmp1; newRow["Amount"] = tmp2;
                    O_table.Rows.Add(newRow);
                }
            }
            txtD.Text = "";
            txtA.Text = "";
        }

        private void m_btn_Click(object sender, EventArgs e)
        {
            if (income_btn.Checked)
            {
                int selectedIndex = dgv_income.CurrentRow.Index;
                if (selectedIndex >= 0 && selectedIndex < I_table.Rows.Count)
                {
                    string newD = txtD.Text;
                    string newA = txtA.Text;
                    I_table.Rows[selectedIndex]["Description"] = newD;
                    I_table.Rows[selectedIndex]["Amount"] = newA;
                }
            }
            else if (outcome_btn.Checked)
            {
                int selectedIndex = dgv_outcome.CurrentRow.Index;
                if (selectedIndex >= 0 && selectedIndex < O_table.Rows.Count)
                {
                    string newD = txtD.Text;
                    string newA = txtA.Text;
                    O_table.Rows[selectedIndex]["Description"] = newD;
                    O_table.Rows[selectedIndex]["Amount"] = newA;
                }
            }
            txtD.Text = "";
            txtA.Text = "";
        }

        private void d_btn_Click(object sender, EventArgs e)
        {
            if (income_btn.Checked)
            {
                int selectedIndex = dgv_income.CurrentRow.Index;
                if (selectedIndex >= 0 && selectedIndex < I_table.Rows.Count)
                {
                    I_table.Rows.RemoveAt(selectedIndex);
                }
            }
            else if (outcome_btn.Checked)
            {
                int selectedIndex = dgv_outcome.CurrentRow.Index;
                if (selectedIndex >= 0 && selectedIndex < O_table.Rows.Count)
                {
                    O_table.Rows.RemoveAt(selectedIndex);
                }
            }
            txtD.Text = "";
            txtA.Text = "";
        }

        private void FormBudget_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

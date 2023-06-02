using project.Properties;
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
    public partial class FormMain : Form
    {
        SQLite main_sql;
        string my_id;

        DataTable t_schedule = new DataTable();
        DataTable t_income = new DataTable();
        DataTable t_outcome = new DataTable();

        public FormMain(string ID, SQLite sql)
        {
            InitializeComponent();
            my_id = ID; 
            main_sql = sql;

            this.Text = ID + "의 WB";

            string attribute1 = "date TEXT," +
                                "schedule TEXT," +
                                "done INTEGER";
            string attribute2 = "date TEXT," +
                              "category TEXT," +
                              "description TEXT," +
                              "amount INTEGER";

            main_sql.create_table(ID + "_scheduler", attribute1);
            main_sql.create_table(ID + "_income", attribute2);
            main_sql.create_table(ID + "_outcome", attribute2);

            t_schedule.TableName = ID+"_scheduler";
            t_schedule.Columns.Add("Date", typeof(string));
            t_schedule.Columns.Add("Schedule", typeof(string));
            t_schedule.Columns.Add("Done", typeof(bool));

            t_income.TableName = ID + "_income";
            t_income.Columns.Add("Date", typeof(string));
            t_income.Columns.Add("Category", typeof(string));
            t_income.Columns.Add("Description", typeof(string));
            t_income.Columns.Add("Amount", typeof(Int32));

            t_outcome.TableName = ID + "_outcome";
            t_outcome.Columns.Add("Date", typeof(string));
            t_outcome.Columns.Add("Category", typeof(string));
            t_outcome.Columns.Add("Description", typeof(string));
            t_outcome.Columns.Add("Amount", typeof(Int32));

            this.Load += setting_schedule;
            this.Load += setting_income;
            this.Load += setting_outcome;

            Calender.DateChanged += setting_schedule;
            Calender.DateChanged += setting_income;
            Calender.DateChanged += setting_outcome;
        }

        public void setting_schedule(object sender, EventArgs e)
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            t_schedule.Clear();
            t_schedule = main_sql.get_schedule($"{my_id}_scheduler", now_date);
            dgvScheduler.DataSource = t_schedule;
        }

        public void setting_income(object sender, EventArgs e)
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            t_income.Clear();
            t_income = main_sql.get_budget($"{my_id}_income", now_date);
            dgvIncome.DataSource = t_income;
        }

        public void setting_outcome(object sender, EventArgs e)
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            t_outcome.Clear();
            t_outcome = main_sql.get_budget($"{my_id}_outcome", now_date);
            dgvOutcome.DataSource = t_outcome;
        }

        private void gboxSchedular_Enter(object sender, EventArgs e)
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            FormScheduler scheduler = new FormScheduler(this, main_sql, t_schedule, my_id, now_date);
            scheduler.Show();

            scheduler.FormClosed += setting_schedule;
        }

        private void gboxBudget_Enter(object sender, EventArgs e)
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            FormBudget budget = new FormBudget(this, main_sql, t_income, t_outcome, my_id, now_date);
            budget.Show();

            budget.FormClosed += setting_income;
            budget.FormClosed += setting_outcome;
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            FormFPR fpr = new FormFPR(this);
            fpr.Show();
        }

        private void btnBack2Login_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            FormR fr = new FormR(this, now_date);
            fr.Show();
        }
    }
}
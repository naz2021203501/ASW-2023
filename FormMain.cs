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
        List<Scheduler> schedulers;
        List<Budget> incomes;
        List<Budget> outcomes;
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
                                "done BOOL";
            string attribute2 = "date TEXT," +
                              "description TEXT," +
                              "amount INTEGER";
            main_sql.create_table(ID + "_scheduler", attribute1);
            main_sql.create_table(ID + "_income", attribute2);
            main_sql.create_table(ID + "_outcome", attribute2);

            t_schedule.Columns.Add("Date", typeof(string));
            t_schedule.Columns.Add("Schedule", typeof(string));
            t_schedule.Columns.Add("Done", typeof(Boolean));

            t_income.Columns.Add("Date", typeof(string));
            t_income.Columns.Add("Description", typeof(string));
            t_income.Columns.Add("Amount", typeof(Int32));

            t_outcome.Columns.Add("Date", typeof(string));
            t_outcome.Columns.Add("Description", typeof(string));
            t_outcome.Columns.Add("Amount", typeof(Int32));

            setting_schedule();
            setting_income();
            setting_outcome();
        }

        public void setting_schedule()
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            schedulers = main_sql.get_schedule($"{my_id}_scheduler", now_date);
            t_schedule.Clear();

            foreach (Scheduler s in schedulers)
            {
                t_schedule.Rows.Add(s.get_date(), s.get_schedule(), s.get_done());
            }
            dgvScheduler.DataSource = t_schedule;
        }

        public void setting_income()
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            incomes = main_sql.get_budget($"{my_id}_income", now_date);
            t_income.Clear();

            foreach (Budget b in incomes)
            {
                t_income.Rows.Add(b.get_date(), b.get_description(), b.get_amount());
            }
            dgvIncome.DataSource = t_income;
        }

        public void setting_outcome()
        {
            string now_date = Calender.SelectionRange.Start.ToString().Substring(0, 10);
            outcomes = main_sql.get_budget($"{my_id}_outcome", now_date);
            t_outcome.Clear();

            foreach (Budget b in outcomes)
            {
                t_outcome.Rows.Add(b.get_date(), b.get_description(), b.get_amount());
            }
            dgvOutcome.DataSource = t_outcome;
        }

        private void gboxSchedular_Enter(object sender, EventArgs e)
        {
            FormScheduler scheduler = new FormScheduler(this);
            scheduler.Show();
        }

        private void gboxBudget_Enter(object sender, EventArgs e)
        {
            FormBudget budget = new FormBudget(this);
            budget.Show();
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

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            setting_schedule();
            setting_income();
            setting_outcome();
        }
    }
}
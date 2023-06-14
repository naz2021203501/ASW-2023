using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace project
{
    public partial class FormR : Form
    {
        FormMain main;
        SQLite sql;
        string date;
        string id;

        public FormR(FormMain main, SQLite sql, string date, string id)
        {
            InitializeComponent();
            this.main = main;
            this.sql = sql;
            this.date = date;
            this.id = id;

            lblDate.Text = $"[{date}]";

            int year_size = DateTime.Now.Year - 1900 + 1;
            string[] year = new string[year_size];
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                year[i - 1900] = i.ToString();
            }
            cboxYear.DataSource = year;
            int indexY = Convert.ToInt32(date.Substring(0, 4))-1900;
            cboxYear.SelectedIndex = indexY;

            string[] month = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    month[i - 1] = "0"+i.ToString();
                }
                else
                {
                    month[i - 1] = i.ToString();
                }
            }
            cboxMonth.DataSource = month;
            int indexM = Convert.ToInt32(date.Substring(5, 2)) - 1;
            cboxMonth.SelectedIndex = indexM;

            rbtnIncome.Checked = true;
        }
        private void re_report(string part_date)
        {
            Dictionary<string, int> report1 = new Dictionary<string, int>();
            Dictionary<string, int> report2 = new Dictionary<string, int>();
            Dictionary<string, int> report3 = new Dictionary<string, int>();
            Dictionary<string, int> report4 = new Dictionary<string, int>();

            report1 = sql.get_report(id + "_income", part_date);
            if (report1.Count > 0)
            {
                var maxIncome = report1.Values.Max();
                var maxIncomeCategory = report1.FirstOrDefault(x => x.Value == maxIncome).Key;
                max_i.Text = "최고 수입은 " + $"{maxIncomeCategory} " + maxIncome.ToString() + "원 입니다.";
            }

            report2 = sql.get_report(id + "_outcome", part_date);
            if (report2.Count > 0)
            {
                var maxOutcome = report2.Values.Max();
                var maxOutcomeCategory = report2.FirstOrDefault(x => x.Value == maxOutcome).Key;
                max_o.Text = "최고 지출은 " + $"{maxOutcomeCategory} " + maxOutcome.ToString() + "원 입니다.";
            }

            string prevMonth = GetPreviousMonth(part_date);

            report3 = sql.get_report(id + "_income", prevMonth);
            report4 = sql.get_report(id + "_outcome", prevMonth);
            
                var sumIncome1 = report3.Values.Sum();
                var sumIncome2 = report1.Values.Sum();
                if (sumIncome1 > sumIncome2)
                {
                    comparison1.Text = "지난 달의 수입이 이번 달 보다 " + (sumIncome1 - sumIncome2) + "원 많고";
                }
                else if (sumIncome1 == sumIncome2)
                {
                    comparison1.Text = "지난 달의 수입과 이번 달의 수입이 같고";
                }
                else {
                    comparison1.Text = "이번 달의 수입이 지난 달 보다 " + (sumIncome2 - sumIncome1) + "원 많고";
                }

                var sumOutcome1 = report4.Values.Sum();
                var sumOutcome2 = report2.Values.Sum();
                if (sumOutcome1 > sumOutcome2)
                {
                    comparison2.Text = "지난 달의 지출이 이번 달 보다 " + (sumOutcome1 - sumOutcome2) + "원 많습니다.";
                }
                else if (sumOutcome1 == sumOutcome2)
                {
                    comparison2.Text = "지난 달의 지출과 이번 달의 지출이 같습니다.";
                }
                else
                {
                    comparison2.Text = "이번 달의 지출이 지난 달 보다 " + (sumOutcome2 - sumOutcome1) + "원 많습니다.";
                }
        }
        private void re_chart(string part_date)
        {
            Dictionary<string, int> report = new Dictionary<string, int>();
            if (rbtnIncome.Checked)
            {
                report = sql.get_report(id+"_income", part_date);

            }
            else if (rbtnOutcome.Checked)
            {
                report = sql.get_report(id + "_outcome", part_date);
            }

            List<string> categories = new List<string>();
            List<int> amounts = new List<int>();

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            if (report.Count > 0)
            {
                foreach (string category in report.Keys)
                {
                    series.Points.AddXY(category, report[category]);
                }
            }
            chartReport.Series.Clear();
            chartReport.ChartAreas.Clear();

            chartReport.Series.Add(series);
            chartReport.ChartAreas.Add(new ChartArea());

            chartReport.Show();
        }

        private void rbtnIncome_CheckedChanged(object sender, EventArgs e)
        {
            string part_date = cboxYear.SelectedItem.ToString () + "-" + cboxMonth.SelectedItem.ToString ();
            re_chart(part_date);
            re_report(part_date);
        }

        private void rbtnOutcome_CheckedChanged(object sender, EventArgs e)
        {
            string part_date = cboxYear.SelectedItem.ToString() + "-" + cboxMonth.SelectedItem.ToString();
            re_chart(part_date);
            re_report(part_date);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string part_date = cboxYear.SelectedItem.ToString() + "-" + cboxMonth.SelectedItem.ToString();
            re_chart(part_date);
            re_report(part_date);
        }
        private string GetPreviousMonth(string currentMonth)
        {
            DateTime currentDate = DateTime.ParseExact(currentMonth, "yyyy-MM", null);
            DateTime previousMonth = currentDate.AddMonths(-1);
            return previousMonth.ToString("yyyy-MM");
        }
    }
}

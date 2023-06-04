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
        }

        private void rbtnOutcome_CheckedChanged(object sender, EventArgs e)
        {
            string part_date = cboxYear.SelectedItem.ToString() + "-" + cboxMonth.SelectedItem.ToString();
            re_chart(part_date);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string part_date = cboxYear.SelectedItem.ToString() + "-" + cboxMonth.SelectedItem.ToString();
            re_chart(part_date);
        }
    }
}

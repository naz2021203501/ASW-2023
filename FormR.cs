using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class FormR : Form
    {
        FormMain main;
        DataSet I_ds = new DataSet();
        DataSet O_ds = new DataSet();
        public FormR(FormMain total_main, string date, DataSet I_ds, DataSet O_ds)
        {
            InitializeComponent();
            main = total_main;

            label6.Text = date;
        }
        private void r_button_Click(object sender, EventArgs e)
        {
            re_chart();
        }

        private void i_button_Click(object sender, EventArgs e)
        {
            re_chart();
        }

        private void o_button_Click(object sender, EventArgs e)
        {
            re_chart();
        }

        void re_chart()
        {
            if (i_button.Checked)
            {
                var grplist = this.I_ds.Data.GroupBy(t => t.Grp);
                chart1.Series[0].Points.Clear();
                foreach (var item in grplist)
                {
                    var grpName = item.FirstOrDefault().Grp;
                    var grpSum = item.Sum(t => t.Cr);
                    chart1.Series[0].Points.AddXY(grpName, grpSum);
                }
            }
            else if (o_button.Checked)
            {
                var grplist = this.O_ds.Data.GroupBy(t => t.Grp);
                chart1.Series[0].Points.Clear();
                foreach (var item in grplist)
                {
                    var grpName = item.FirstOrDefault().Grp;
                    var grpSum = item.Sum(t => t.Cr);
                    chart1.Series[0].Points.AddXY(grpName, grpSum);
                }
            }
        }
    }
}

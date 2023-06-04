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

        private void i_rbtn_Click(object sender, EventArgs e)
        {
            re_chart();
        }

        private void o_rbtn_Click(object sender, EventArgs e)
        {
            re_chart();
        }

        void re_chart()
        {
            if (i_rbtn.Checked)
            {
                
            }
            else if (o_rbtn.Checked)
            {
                
            }
        }
    }
}

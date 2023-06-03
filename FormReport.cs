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
    public partial class FormReport : Form
    {
        FormMain main;
        DataTable income;
        DataTable outcome;
        string id;

        Graphics g;
        Dictionary<string, decimal> sum_of_category;

        // Paint 이벤트 핸들러
        private void Paint_Chart(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            sum_of_category = new Dictionary<string, decimal>();
            sum_of_category["용돈"] = 300000;
            sum_of_category["월급"] = 600000;
            sum_of_category["이자"] = 4000;

            decimal sum = 0;
            foreach (string category in sum_of_category.Keys)
            {
                sum += sum_of_category[category];
            }

            SolidBrush c1 = new SolidBrush(Color.Blue);
            SolidBrush c2 = new SolidBrush(Color.Red);
            SolidBrush c3 = new SolidBrush(Color.Yellow);

            if (sum != 0)
            {
                int s1 = (int)(sum_of_category["용돈"] / sum * 360);
                g.FillPie(c1, 130, 110, 100, 100, 0, s1);
                int s2 = (int)(sum_of_category["월급"] / sum * 360);
                g.FillPie(c2, 130, 110, 100, 100, s1, s2);
                int s3 = (int)(sum_of_category["이자"] / sum * 360);
                g.FillPie(c3, 130, 110, 100, 100, s1 + s2, s3);
            }
        }

        public FormReport(FormMain main, DataTable t_income, DataTable t_outcome, string my_id)
        {
            InitializeComponent();
            
            this.main = main;
            this.income = t_income;
            this.outcome = t_outcome;
            this.id = my_id;
            
            g = CreateGraphics();

            this.Paint += new PaintEventHandler(Paint_Chart);
        }
    }
}

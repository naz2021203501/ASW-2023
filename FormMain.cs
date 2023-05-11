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

        public FormMain(string ID)
        {
            InitializeComponent();
            this.Text = ID + "의 WB";
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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
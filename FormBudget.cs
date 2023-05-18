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
        public FormBudget(FormMain total_main)
        {
            main = total_main;
            InitializeComponent();
        }

        private void cboxIncome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

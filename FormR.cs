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
        public FormR(FormMain total_main, string date)
        {
            InitializeComponent();
            main = total_main;

            label6.Text = date;
        }
    }
}

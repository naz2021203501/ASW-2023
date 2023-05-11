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
    public partial class FormFPR : Form
    {
        FormMain main;
        public FormFPR(FormMain total_main)
        {
            InitializeComponent();
            main = total_main;
        }
    }
}

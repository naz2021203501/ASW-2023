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
    public partial class FormScheduler : Form
    {
        FormMain main;
        private CheckedListBox cboxScheduler;
        private Button btnAdd;
        private Button btnDelete;

        public FormScheduler(FormMain total_form)
        {
            InitializeComponent();
            main = total_form;
        }

        private void FormScheduler_Load(object sender, EventArgs e)
        {
            this.cboxScheduler = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxScheduler
            // 
            this.cboxScheduler.Font = new System.Drawing.Font("굴림", 15F);
            this.cboxScheduler.FormattingEnabled = true;
            this.cboxScheduler.Location = new System.Drawing.Point(41, 35);
            this.cboxScheduler.Name = "cboxScheduler";
            this.cboxScheduler.Size = new System.Drawing.Size(439, 252);
            this.cboxScheduler.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 40F);
            this.btnAdd.Location = new System.Drawing.Point(530, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 82);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 40F);
            this.btnDelete.Location = new System.Drawing.Point(530, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 82);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 328);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxScheduler);
            this.Name = "FormScheduler";
            this.Text = "Scheduler";
            this.ResumeLayout(false);
        }
    }
}

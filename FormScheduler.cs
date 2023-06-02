using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace project
{
    public partial class FormScheduler : Form
    {
        FormMain main;
        SQLite sql;
        DataTable s_table;
        string table_name;
        string date;

        int count = 0;
        bool isEdited = false;
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }
        private void checkbox_StateChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }
        public void delete_Schedule(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "스케줄 삭제", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                isEdited = true;
                Button clickedButton = (Button)sender;
                Panel parentPanel = (Panel)clickedButton.Parent;
                parentPanel.Parent.Controls.Remove(parentPanel);
            }
        }
        public Panel create_schedule()
        {
            string name = count++.ToString();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Name = "pnl" + name;

            System.Windows.Forms.CheckBox checkbox = new System.Windows.Forms.CheckBox();
            checkbox.Name = "cbox" + name;
            checkbox.Text = "";
            checkbox.Size = new Size(18, 17);
            checkbox.Dock = DockStyle.Left;
            checkbox.CheckedChanged += checkbox_StateChanged;

            TextBox textbox = new TextBox();
            textbox.Name = "txt" + name;
            textbox.Size = new Size(200, 17);
            textbox.Dock = DockStyle.Fill;
            textbox.Text = name;
            textbox.TextChanged += textbox_TextChanged;

            Button deletebutton = new Button();
            deletebutton.Name = "btn" + name;
            deletebutton.Text = "-";
            deletebutton.AutoSize = true; deletebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletebutton.Dock = DockStyle.Right;
            deletebutton.Click += delete_Schedule;

            panel.Controls.Add(checkbox);
            panel.Controls.Add(textbox);
            panel.Controls.Add(deletebutton);

            panel.AutoSize = true; panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            return panel;
        }
        public Panel create_schedule(string s_text, bool s_bool)
        {
            string name = count++.ToString();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Name = "pnl" + name;

            System.Windows.Forms.CheckBox checkbox = new System.Windows.Forms.CheckBox();
            checkbox.Name = "cbox" + name;
            checkbox.Text = "";
            checkbox.Checked = s_bool;
            checkbox.Size = new Size(18, 17);
            checkbox.Dock = DockStyle.Left;
            checkbox.CheckedChanged += checkbox_StateChanged;

            TextBox textbox = new TextBox();
            textbox.Name = "txt" + name;
            textbox.Size = new Size(200, 17);
            textbox.Dock = DockStyle.Fill;
            textbox.Text = s_text;
            textbox.TextChanged += textbox_TextChanged;

            Button deletebutton = new Button();
            deletebutton.Name = "btn" + name;
            deletebutton.Text = "-";
            deletebutton.AutoSize = true; deletebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletebutton.Dock = DockStyle.Right;
            deletebutton.Click += delete_Schedule;

            panel.Controls.Add(checkbox);
            panel.Controls.Add(textbox);
            panel.Controls.Add(deletebutton);

            panel.AutoSize = true; panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            return panel;
        }    
        public FormScheduler(FormMain total_form, SQLite main_sql, DataTable s_table, string ID, string date)
        {
            InitializeComponent();
            main = total_form;
            this.sql = main_sql;
            this.s_table = s_table;
            this.table_name = ID + "_scheduler";
            this.date = date; lblDate.Text = $"[{date}]";
            this.FormClosing += save_data;

            pnlSchedule.FlowDirection = FlowDirection.TopDown;
            pnlSchedule.WrapContents = false;

            if (s_table.Rows.Count > 0)
            {
                foreach (DataRow row in s_table.Rows)
                {
                    string s_text = row.Field<string>("Schedule");
                    bool s_bool = row.Field<bool>("Done");
                    Panel pnl = create_schedule(s_text, s_bool);
                    pnlSchedule.Controls.Add(pnl);
                }
            }         
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            isEdited = true;
            Panel pnl = create_schedule();  
            pnlSchedule.Controls.Add(pnl);
            pnlSchedule.Controls.SetChildIndex(pnl, count);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private bool check_save()
        {
            return isEdited;
        }
        public void save_data(object sender, EventArgs e)
        {
            if (check_save())
            {
                sql.delete_data(table_name, date);
                if(pnlSchedule.Controls.Count > 0) {
                    foreach (Panel pnl in pnlSchedule.Controls)
                    {
                        if (pnlSchedule.Controls.Count > 0)
                        {
                            string newSchedule = string.Empty;
                            int newDone = 2;
                            foreach (Control control in pnl.Controls)
                            {
                                if (control is System.Windows.Forms.CheckBox checkbox)
                                {
                                    if (checkbox.Checked == true) {
                                        newDone = 1;
                                    }
                                    else
                                    {
                                        newDone = 0;
                                    }
                                }
                                if (control is TextBox textbox){
                                    newSchedule = textbox.Text;
                                }
                            }
                            if (newSchedule != string.Empty)
                            {
                                sql.add_schedule(table_name, date, newSchedule, newDone);
                            }
                        }
                    }
                }
                MessageBox.Show("변경사항을 저장했습니다", "스케줄 저장", MessageBoxButtons.OK);
            }
        }
    }
}
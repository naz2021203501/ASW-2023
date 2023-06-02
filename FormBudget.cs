using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace project
{
    public partial class FormBudget : Form
    {
        FormMain main;
        SQLite sql;
        DataTable i_table;
        DataTable o_table;
        string table_name;
        string date;

        string[] icategory = { "월급", "용돈", "이자" };
        string[] ocategory = { "식비", "교통비", "통신비", "의류비", "관리비", "생필품"};

        int count = 0;
        bool isEdited = false;
        public void combobox_IndexChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }
        public void textbox_TextChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }
        public void delete_Budget(object sender, EventArgs e)
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
        private Panel create_income()
        {
            string name = count++.ToString();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Name = "pnl" + name;
            panel.Dock = DockStyle.Left;
            panel.Width = pnlIncome.Width;

            ComboBox combobox = new ComboBox();
            combobox.Name = "cmbbox" + name;
            combobox.Dock = DockStyle.Left;
            combobox.Width = panel.Width / 4;
            combobox.DataSource = icategory;
            combobox.SelectedIndexChanged += combobox_IndexChanged;

            TextBox textboxd = new TextBox();
            textboxd.Name = "txtd" + name;
            textboxd.Text = name;
            textboxd.Width = panel.Width / 4 + 23;
            textboxd.TextChanged += textbox_TextChanged;

            TextBox textboxa = new TextBox();
            textboxa.Name = "txta" + name;
            textboxa.Text = name;
            textboxa.TextAlign = HorizontalAlignment.Right;
            textboxa.Width = panel.Width / 4 + 11;
            textboxa.TextChanged += textbox_TextChanged;

            Button deletebutton = new Button();
            deletebutton.Name = "btn" + name;
            deletebutton.Text = "-";
            deletebutton.AutoSize = true; deletebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletebutton.Dock = DockStyle.Right;
            deletebutton.Click += delete_Budget;

            panel.Controls.Add(combobox);
            panel.Controls.Add(textboxd);
            panel.Controls.Add(textboxa);
            panel.Controls.Add(deletebutton);

            panel.AutoSize = true; panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            return panel;
        }
        private Panel create_income(string category, string description, int amount)
        {
            string name = count++.ToString();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Name = "pnl" + name;
            panel.Dock = DockStyle.Left;
            panel.Width = pnlIncome.Width;

            ComboBox combobox = new ComboBox();
            combobox.Name = "cmbbox" + name;
            combobox.Dock = DockStyle.Left;
            combobox.Width = panel.Width / 4;
            combobox.DataSource = icategory;
            combobox.SelectedItem = category;
            combobox.SelectedIndexChanged += combobox_IndexChanged;

            TextBox textboxd = new TextBox();
            textboxd.Name = "txtd" + name;
            textboxd.Text = description;
            textboxd.TextChanged += textbox_TextChanged;
            textboxd.Width = panel.Width / 4 + 23;

            TextBox textboxa = new TextBox();
            textboxa.Name = "txta" + name;
            textboxa.Text = amount.ToString();
            textboxa.TextAlign = HorizontalAlignment.Right;
            textboxa.Width = panel.Width / 4 + 11;

            Button deletebutton = new Button();
            deletebutton.Name = "btn" + name;
            deletebutton.Text = "-";
            deletebutton.AutoSize = true; deletebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletebutton.Dock = DockStyle.Right;
            deletebutton.Click += delete_Budget;

            panel.Controls.Add(combobox);
            panel.Controls.Add(textboxd);
            panel.Controls.Add(textboxa);
            panel.Controls.Add(deletebutton);

            panel.AutoSize = true; panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            return panel;
        }
        private Panel create_outcome()
        {
            string name = count++.ToString();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Name = "pnl" + name;
            panel.Dock = DockStyle.Left;
            panel.Width = pnlIncome.Width;

            ComboBox combobox = new ComboBox();
            combobox.Name = "cmbbox" + name;
            combobox.Dock = DockStyle.Left;
            combobox.Width = panel.Width / 4;
            combobox.DataSource = ocategory;
            combobox.SelectedIndexChanged += combobox_IndexChanged;

            TextBox textboxd = new TextBox();
            textboxd.Name = "txtd" + name;
            textboxd.Text = name;
            textboxd.Width = panel.Width / 4 + 23;
            textboxd.TextChanged += textbox_TextChanged;

            TextBox textboxa = new TextBox();
            textboxa.Name = "txta" + name;
            textboxa.Text = name;
            textboxa.TextAlign = HorizontalAlignment.Right;
            textboxa.Width = panel.Width / 4 + 11;
            textboxa.TextChanged += textbox_TextChanged;

            Button deletebutton = new Button();
            deletebutton.Name = "btn" + name;
            deletebutton.Text = "-";
            deletebutton.AutoSize = true; deletebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletebutton.Dock = DockStyle.Right;
            deletebutton.Click += delete_Budget;

            panel.Controls.Add(combobox);
            panel.Controls.Add(textboxd);
            panel.Controls.Add(textboxa);
            panel.Controls.Add(deletebutton);

            panel.AutoSize = true; panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            return panel;
        }
        private Panel create_outcome(string category, string description, int amount)
        {
            string name = count++.ToString();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Name = "pnl" + name;
            panel.Dock = DockStyle.Left;
            panel.Width = pnlOutcome.Width;

            ComboBox combobox = new ComboBox();
            combobox.Name = "cmbbox" + name;
            combobox.SelectedItem = category;
            combobox.Dock = DockStyle.Left;
            combobox.Width = panel.Width / 4;
            combobox.DataSource = ocategory;
            combobox.SelectedIndexChanged += combobox_IndexChanged;

            TextBox textboxd = new TextBox();
            textboxd.Name = "txtd" + name;
            textboxd.Text = description;
            textboxd.TextChanged += textbox_TextChanged;
            textboxd.Width = panel.Width / 4 + 23;

            TextBox textboxa = new TextBox();
            textboxa.Name = "txta" + name;
            textboxa.Text = amount.ToString();
            textboxa.TextAlign = HorizontalAlignment.Right;
            textboxa.Width = panel.Width / 4 + 11;

            Button deletebutton = new Button();
            deletebutton.Name = "btn" + name;
            deletebutton.Text = "-";
            deletebutton.AutoSize = true; deletebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deletebutton.Dock = DockStyle.Right;
            deletebutton.Click += delete_Budget;

            panel.Controls.Add(combobox);
            panel.Controls.Add(textboxd);
            panel.Controls.Add(textboxa);
            panel.Controls.Add(deletebutton);

            panel.AutoSize = true; panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            return panel;
        }
        public FormBudget(FormMain total_main, SQLite main_sql, DataTable t_income, DataTable t_outcome, string my_id, string date)
        {
            InitializeComponent();
            this.main = total_main;
            this.sql = main_sql;
            this.i_table = t_income;
            this.o_table = t_outcome;
            this.table_name = my_id;
            this.date = date; lblDate.Text = $"[{date}]";
            this.FormClosing += save_data;

            pnlIncome.FlowDirection = FlowDirection.TopDown;
            pnlIncome.WrapContents = false;

            pnlOutcome.FlowDirection = FlowDirection.TopDown;
            pnlOutcome.WrapContents = false;

            if (i_table.Rows.Count > 0)
            {
                foreach (DataRow row in i_table.Rows)
                {
                    string i_category = row.Field<string>("Category");
                    string i_description = row.Field<string>("Description");
                    int i_amount = row.Field<Int32>("Amount");
                    Panel pnl = create_income(i_category, i_description, i_amount);
                    pnlIncome.Controls.Add(pnl);
                }
            }

            if(o_table.Rows.Count > 0)
            {
                foreach (DataRow row in o_table.Rows)
                {
                    string o_category = row.Field<string>("Category");
                    string o_description = row.Field<string>("Description");
                    int o_amount = row.Field<Int32>("Amount");
                    Panel pnl = create_outcome(o_category, o_description, o_amount);
                    pnlOutcome.Controls.Add(pnl);
                }
            }
        }
        private void btnIPlus_Click(object sender, EventArgs e)
        {
            isEdited = true;
            Panel pnl = create_income();
            pnlIncome.Controls.Add(pnl);
        }
        private void btnOPlus_Click(object sender, EventArgs e)
        {
            isEdited = true;
            Panel pnl = create_outcome();
            pnlOutcome.Controls.Add(pnl);
        }
        private bool check_save()
        {
            return isEdited;
        }
        public void save_data(object sender, EventArgs e)
        {
            if (check_save())
            {
                sql.delete_data(table_name + "_income", date);
                if (pnlIncome.Controls.Count > 0)
                {
                    foreach (Panel pnl in pnlIncome.Controls)
                    {
                        if (pnlIncome.Controls.Count > 0)
                        {
                            string newCategory = string.Empty;
                            string newDescription = string.Empty;
                            int newAmount = 0;
                            bool isFirst = false;
                            foreach (Control control in pnl.Controls)
                            {
                                if (control is ComboBox combobox)
                                {
                                    newCategory = combobox.SelectedItem.ToString();
                                }
                                if (control is TextBox textbox)
                                {
                                    if (isFirst == false)
                                    {
                                        isFirst = true;
                                        newDescription = textbox.Text;
                                    }
                                    else
                                    {
                                        string tmpAmount = textbox.Text.Replace("$", "").Replace(",", "");
                                        newAmount = Convert.ToInt32(tmpAmount);
                                    }
                                }
                            }
                            if (newDescription != string.Empty && newAmount > 0)
                            {
                                sql.add_budget(table_name + "_income", date, newCategory, newDescription, newAmount);
                            }
                        }
                    }
                }

                sql.delete_data(table_name + "_outcome", date);
                if (pnlOutcome.Controls.Count > 0)
                {
                    foreach (Panel pnl in pnlOutcome.Controls)
                    {
                        if (pnlOutcome.Controls.Count > 0)
                        {
                            string newCategory = string.Empty;
                            string newDescription = string.Empty;
                            int newAmount = 0;
                            bool isFirst = false;
                            foreach (Control control in pnl.Controls)
                            {
                                if (control is ComboBox combobox)
                                {
                                    newCategory = combobox.SelectedItem.ToString();
                                }
                                if (control is TextBox textbox)
                                {
                                    if (isFirst == false)
                                    {
                                        isFirst = true;
                                        newDescription = textbox.Text;
                                    }
                                    else
                                    {
                                        string tmpAmount = textbox.Text.Replace("$", "").Replace(",", "");
                                        newAmount = Convert.ToInt32(tmpAmount);
                                    }
                                }
                            }
                            if (newDescription != string.Empty && newAmount > 0)
                            {
                                sql.add_budget(table_name + "_outcome", date, newCategory, newDescription, newAmount);
                            }
                        }
                    }
                }

                MessageBox.Show("변경사항을 저장했습니다", "스케줄 저장", MessageBoxButtons.OK);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

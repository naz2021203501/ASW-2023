namespace project
{
    partial class FormSignin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxSignin = new System.Windows.Forms.GroupBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.gboxIdandPw = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.Button();
            this.btnUsable = new System.Windows.Forms.Button();
            this.lblCheckPw = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtCheckPw = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.gboxInformation = new System.Windows.Forms.GroupBox();
            this.lblUnderbar2 = new System.Windows.Forms.Label();
            this.lblUnderbar1 = new System.Windows.Forms.Label();
            this.txtPH1 = new System.Windows.Forms.TextBox();
            this.txtPH2 = new System.Windows.Forms.TextBox();
            this.txtPH3 = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gboxSignin.SuspendLayout();
            this.gboxIdandPw.SuspendLayout();
            this.gboxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSignin
            // 
            this.gboxSignin.Controls.Add(this.btnComplete);
            this.gboxSignin.Controls.Add(this.gboxIdandPw);
            this.gboxSignin.Controls.Add(this.gboxInformation);
            this.gboxSignin.Location = new System.Drawing.Point(12, 12);
            this.gboxSignin.Name = "gboxSignin";
            this.gboxSignin.Size = new System.Drawing.Size(799, 278);
            this.gboxSignin.TabIndex = 0;
            this.gboxSignin.TabStop = false;
            this.gboxSignin.Text = "Sign In";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(542, 219);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(151, 50);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // gboxIdandPw
            // 
            this.gboxIdandPw.Controls.Add(this.btnCheck);
            this.gboxIdandPw.Controls.Add(this.btnVisible);
            this.gboxIdandPw.Controls.Add(this.btnUsable);
            this.gboxIdandPw.Controls.Add(this.lblCheckPw);
            this.gboxIdandPw.Controls.Add(this.txtId);
            this.gboxIdandPw.Controls.Add(this.lblPW);
            this.gboxIdandPw.Controls.Add(this.txtCheckPw);
            this.gboxIdandPw.Controls.Add(this.lblId);
            this.gboxIdandPw.Controls.Add(this.txtPw);
            this.gboxIdandPw.Location = new System.Drawing.Point(424, 24);
            this.gboxIdandPw.Name = "gboxIdandPw";
            this.gboxIdandPw.Size = new System.Drawing.Size(375, 181);
            this.gboxIdandPw.TabIndex = 4;
            this.gboxIdandPw.TabStop = false;
            this.gboxIdandPw.Text = "ID and PW";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(294, 121);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 29);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(294, 82);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(70, 29);
            this.btnVisible.TabIndex = 15;
            this.btnVisible.Text = "Visible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // btnUsable
            // 
            this.btnUsable.Location = new System.Drawing.Point(294, 45);
            this.btnUsable.Name = "btnUsable";
            this.btnUsable.Size = new System.Drawing.Size(70, 26);
            this.btnUsable.TabIndex = 12;
            this.btnUsable.Text = "Usable";
            this.btnUsable.UseVisualStyleBackColor = true;
            this.btnUsable.Click += new System.EventHandler(this.btnUsable_Click);
            // 
            // lblCheckPw
            // 
            this.lblCheckPw.AutoSize = true;
            this.lblCheckPw.Location = new System.Drawing.Point(13, 127);
            this.lblCheckPw.Name = "lblCheckPw";
            this.lblCheckPw.Size = new System.Drawing.Size(77, 15);
            this.lblCheckPw.TabIndex = 8;
            this.lblCheckPw.Text = "Check PW";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(192, 25);
            this.txtId.TabIndex = 11;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(13, 89);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(31, 15);
            this.lblPW.TabIndex = 6;
            this.lblPW.Text = "PW";
            // 
            // txtCheckPw
            // 
            this.txtCheckPw.Location = new System.Drawing.Point(96, 124);
            this.txtCheckPw.Name = "txtCheckPw";
            this.txtCheckPw.PasswordChar = '*';
            this.txtCheckPw.Size = new System.Drawing.Size(192, 25);
            this.txtCheckPw.TabIndex = 14;
            this.txtCheckPw.TextChanged += new System.EventHandler(this.txtCheckPw_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(96, 86);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(192, 25);
            this.txtPw.TabIndex = 13;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged);
            // 
            // gboxInformation
            // 
            this.gboxInformation.Controls.Add(this.lblUnderbar2);
            this.gboxInformation.Controls.Add(this.lblUnderbar1);
            this.gboxInformation.Controls.Add(this.txtPH1);
            this.gboxInformation.Controls.Add(this.txtPH2);
            this.gboxInformation.Controls.Add(this.txtPH3);
            this.gboxInformation.Controls.Add(this.lblPhoneNumber);
            this.gboxInformation.Controls.Add(this.rdoFemale);
            this.gboxInformation.Controls.Add(this.rdoMale);
            this.gboxInformation.Controls.Add(this.cmbYear);
            this.gboxInformation.Controls.Add(this.cmbDate);
            this.gboxInformation.Controls.Add(this.cmbMonth);
            this.gboxInformation.Controls.Add(this.lblSex);
            this.gboxInformation.Controls.Add(this.lblEmail);
            this.gboxInformation.Controls.Add(this.txtEmail);
            this.gboxInformation.Controls.Add(this.lblName);
            this.gboxInformation.Controls.Add(this.lblDOB);
            this.gboxInformation.Controls.Add(this.txtName);
            this.gboxInformation.Location = new System.Drawing.Point(6, 24);
            this.gboxInformation.Name = "gboxInformation";
            this.gboxInformation.Size = new System.Drawing.Size(402, 247);
            this.gboxInformation.TabIndex = 3;
            this.gboxInformation.TabStop = false;
            this.gboxInformation.Text = "Information";
            // 
            // lblUnderbar2
            // 
            this.lblUnderbar2.AutoSize = true;
            this.lblUnderbar2.Location = new System.Drawing.Point(272, 213);
            this.lblUnderbar2.Name = "lblUnderbar2";
            this.lblUnderbar2.Size = new System.Drawing.Size(15, 15);
            this.lblUnderbar2.TabIndex = 23;
            this.lblUnderbar2.Text = "-";
            // 
            // lblUnderbar1
            // 
            this.lblUnderbar1.AutoSize = true;
            this.lblUnderbar1.Location = new System.Drawing.Point(148, 213);
            this.lblUnderbar1.Name = "lblUnderbar1";
            this.lblUnderbar1.Size = new System.Drawing.Size(15, 15);
            this.lblUnderbar1.TabIndex = 22;
            this.lblUnderbar1.Text = "-";
            // 
            // txtPH1
            // 
            this.txtPH1.Location = new System.Drawing.Point(64, 210);
            this.txtPH1.Name = "txtPH1";
            this.txtPH1.Size = new System.Drawing.Size(78, 25);
            this.txtPH1.TabIndex = 8;
            // 
            // txtPH2
            // 
            this.txtPH2.Location = new System.Drawing.Point(169, 210);
            this.txtPH2.Name = "txtPH2";
            this.txtPH2.Size = new System.Drawing.Size(95, 25);
            this.txtPH2.TabIndex = 9;
            // 
            // txtPH3
            // 
            this.txtPH3.Location = new System.Drawing.Point(293, 210);
            this.txtPH3.Name = "txtPH3";
            this.txtPH3.Size = new System.Drawing.Size(95, 25);
            this.txtPH3.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 213);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(27, 15);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "PH";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(141, 126);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 19);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(64, 126);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(59, 19);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(61, 79);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(94, 23);
            this.cmbYear.TabIndex = 2;
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(230, 79);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(56, 23);
            this.cmbDate.TabIndex = 4;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(164, 79);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(60, 23);
            this.cmbMonth.TabIndex = 3;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(14, 128);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 15);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sex";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(14, 82);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(39, 15);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 25);
            this.txtName.TabIndex = 1;
            // 
            // FormSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 298);
            this.Controls.Add(this.gboxSignin);
            this.Name = "FormSignin";
            this.Text = "Signin";
            this.gboxSignin.ResumeLayout(false);
            this.gboxIdandPw.ResumeLayout(false);
            this.gboxIdandPw.PerformLayout();
            this.gboxInformation.ResumeLayout(false);
            this.gboxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxSignin;
        private System.Windows.Forms.GroupBox gboxInformation;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.GroupBox gboxIdandPw;
        private System.Windows.Forms.Label lblCheckPw;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtCheckPw;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblUnderbar2;
        private System.Windows.Forms.Label lblUnderbar1;
        private System.Windows.Forms.TextBox txtPH1;
        private System.Windows.Forms.TextBox txtPH2;
        private System.Windows.Forms.TextBox txtPH3;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnUsable;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Button btnCheck;
    }
}
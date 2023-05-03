namespace loginform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bday = new System.Windows.Forms.Label();
            this.signin_id = new System.Windows.Forms.Label();
            this.signin_pw = new System.Windows.Forms.Label();
            this.textBox_bday = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.textBox_PW2 = new System.Windows.Forms.TextBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_id_verification = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.bt_sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bday
            // 
            this.bday.AutoSize = true;
            this.bday.Location = new System.Drawing.Point(173, 109);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(67, 15);
            this.bday.TabIndex = 1;
            this.bday.Text = "생년월일";
            // 
            // signin_id
            // 
            this.signin_id.AutoSize = true;
            this.signin_id.Location = new System.Drawing.Point(184, 153);
            this.signin_id.Name = "signin_id";
            this.signin_id.Size = new System.Drawing.Size(52, 15);
            this.signin_id.TabIndex = 2;
            this.signin_id.Text = "아이디";
            this.signin_id.Click += new System.EventHandler(this.signin_id_Click);
            // 
            // signin_pw
            // 
            this.signin_pw.AutoSize = true;
            this.signin_pw.Location = new System.Drawing.Point(169, 197);
            this.signin_pw.Name = "signin_pw";
            this.signin_pw.Size = new System.Drawing.Size(67, 15);
            this.signin_pw.TabIndex = 4;
            this.signin_pw.Text = "비밀번호";
            // 
            // textBox_bday
            // 
            this.textBox_bday.Location = new System.Drawing.Point(253, 99);
            this.textBox_bday.Name = "textBox_bday";
            this.textBox_bday.Size = new System.Drawing.Size(169, 25);
            this.textBox_bday.TabIndex = 6;
            this.textBox_bday.TextChanged += new System.EventHandler(this.textBox_bday_TextChanged);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(253, 143);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(169, 25);
            this.textBox_ID.TabIndex = 7;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(253, 187);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(169, 25);
            this.textBox_PW.TabIndex = 8;
            this.textBox_PW.TextChanged += new System.EventHandler(this.textBox_PW_TextChanged);
            // 
            // textBox_PW2
            // 
            this.textBox_PW2.Location = new System.Drawing.Point(252, 231);
            this.textBox_PW2.Name = "textBox_PW2";
            this.textBox_PW2.Size = new System.Drawing.Size(169, 25);
            this.textBox_PW2.TabIndex = 9;
            this.textBox_PW2.TextChanged += new System.EventHandler(this.textBox_PW2_TextChanged);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(253, 275);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 10;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_id_verification
            // 
            this.bt_id_verification.Location = new System.Drawing.Point(441, 145);
            this.bt_id_verification.Name = "bt_id_verification";
            this.bt_id_verification.Size = new System.Drawing.Size(129, 23);
            this.bt_id_verification.TabIndex = 12;
            this.bt_id_verification.Text = "ID verification";
            this.bt_id_verification.UseVisualStyleBackColor = true;
            this.bt_id_verification.Click += new System.EventHandler(this.bt_id_verification_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(199, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 13;
            this.name.Text = "이름";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(253, 58);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(168, 25);
            this.textBox_name.TabIndex = 14;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // bt_sign_in
            // 
            this.bt_sign_in.Location = new System.Drawing.Point(347, 275);
            this.bt_sign_in.Name = "bt_sign_in";
            this.bt_sign_in.Size = new System.Drawing.Size(75, 23);
            this.bt_sign_in.TabIndex = 15;
            this.bt_sign_in.Text = "SIGN IN";
            this.bt_sign_in.UseVisualStyleBackColor = true;
            this.bt_sign_in.Click += new System.EventHandler(this.bt_sign_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_sign_in);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bt_id_verification);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.textBox_PW2);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_bday);
            this.Controls.Add(this.signin_pw);
            this.Controls.Add(this.signin_id);
            this.Controls.Add(this.bday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bday;
        private System.Windows.Forms.Label signin_id;
        private System.Windows.Forms.Label signin_pw;
        private System.Windows.Forms.TextBox textBox_bday;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.TextBox textBox_PW2;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_id_verification;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button bt_sign_in;
    }
}


namespace project
{
    partial class FormLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gboxInit = new System.Windows.Forms.GroupBox();
            this.lblPw = new System.Windows.Forms.Label();
            this.gboxInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(90, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(320, 152);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(131, 44);
            this.btnSignin.TabIndex = 1;
            this.btnSignin.Text = "SIGN IN";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(361, 25);
            this.txtId.TabIndex = 2;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(130, 97);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(361, 25);
            this.txtPw.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(63, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // gboxInit
            // 
            this.gboxInit.Controls.Add(this.lblPw);
            this.gboxInit.Controls.Add(this.lblId);
            this.gboxInit.Controls.Add(this.txtPw);
            this.gboxInit.Controls.Add(this.txtId);
            this.gboxInit.Controls.Add(this.btnSignin);
            this.gboxInit.Controls.Add(this.btnLogin);
            this.gboxInit.Location = new System.Drawing.Point(12, 12);
            this.gboxInit.Name = "gboxInit";
            this.gboxInit.Size = new System.Drawing.Size(556, 211);
            this.gboxInit.TabIndex = 5;
            this.gboxInit.TabStop = false;
            this.gboxInit.Text = "Welcome to WB";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(63, 100);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(31, 15);
            this.lblPw.TabIndex = 5;
            this.lblPw.Text = "PW";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 230);
            this.Controls.Add(this.gboxInit);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.gboxInit.ResumeLayout(false);
            this.gboxInit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gboxInit;
        private System.Windows.Forms.Label lblPw;
    }
}


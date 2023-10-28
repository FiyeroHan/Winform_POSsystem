namespace Unicon1.ucPanel
{
    partial class ucLogin
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cboxPWVisible = new System.Windows.Forms.CheckBox();
            this.tboxID = new VerticalTextBox();
            this.verticalTextBox1 = new VerticalTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(386, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tboxPW
            // 
            this.tboxPW.Location = new System.Drawing.Point(397, 257);
            this.tboxPW.Multiline = true;
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.PasswordChar = '*';
            this.tboxPW.Size = new System.Drawing.Size(154, 37);
            this.tboxPW.TabIndex = 2;
            this.tboxPW.Text = "6d4f1aec6d5e2b29816d617e952c3a10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "PW";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(607, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cboxPWVisible
            // 
            this.cboxPWVisible.AutoSize = true;
            this.cboxPWVisible.Location = new System.Drawing.Point(397, 300);
            this.cboxPWVisible.Name = "cboxPWVisible";
            this.cboxPWVisible.Size = new System.Drawing.Size(100, 16);
            this.cboxPWVisible.TabIndex = 6;
            this.cboxPWVisible.Text = "비밀번호 보기";
            this.cboxPWVisible.UseVisualStyleBackColor = true;
            this.cboxPWVisible.CheckedChanged += new System.EventHandler(this.cboxPWVisible_CheckedChanged);
            // 
            // tboxID
            // 
            this.tboxID.BackColor = System.Drawing.SystemColors.Window;
            this.tboxID.BorderColor = System.Drawing.Color.Gray;
            this.tboxID.LeftRightPadding = ((uint)(10u));
            this.tboxID.Location = new System.Drawing.Point(397, 207);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(159, 44);
            this.tboxID.TabIndex = 7;
            this.tboxID.Text = "store@ddingdong.com";
            this.tboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // verticalTextBox1
            // 
            this.verticalTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.verticalTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.verticalTextBox1.LeftRightPadding = ((uint)(10u));
            this.verticalTextBox1.Location = new System.Drawing.Point(557, 278);
            this.verticalTextBox1.Name = "verticalTextBox1";
            this.verticalTextBox1.Size = new System.Drawing.Size(149, 56);
            this.verticalTextBox1.TabIndex = 8;
            this.verticalTextBox1.Text = "6d4f1aec6d5e2b29816d617e952c3a10";
            this.verticalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalTextBox1);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.cboxPWVisible);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPW);
            this.Controls.Add(this.label1);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(977, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cboxPWVisible;
        private VerticalTextBox tboxID;
        private VerticalTextBox verticalTextBox1;
    }
}

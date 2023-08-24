namespace Unicon1.ucPanel
{
    partial class ucDucth2
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
            this.lblRestofPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPricePerRound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumPerson = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRestofPrice
            // 
            this.lblRestofPrice.AutoSize = true;
            this.lblRestofPrice.Font = new System.Drawing.Font("굴림", 11F);
            this.lblRestofPrice.Location = new System.Drawing.Point(591, 97);
            this.lblRestofPrice.Name = "lblRestofPrice";
            this.lblRestofPrice.Size = new System.Drawing.Size(27, 26);
            this.lblRestofPrice.TabIndex = 1;
            this.lblRestofPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(102, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "잔여 결제 금액:";
            // 
            // lblPricePerRound
            // 
            this.lblPricePerRound.AutoSize = true;
            this.lblPricePerRound.Font = new System.Drawing.Font("굴림", 11F);
            this.lblPricePerRound.Location = new System.Drawing.Point(591, 487);
            this.lblPricePerRound.Name = "lblPricePerRound";
            this.lblPricePerRound.Size = new System.Drawing.Size(27, 26);
            this.lblPricePerRound.TabIndex = 3;
            this.lblPricePerRound.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(102, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "회당 결제 금액:";
            // 
            // lblNumPerson
            // 
            this.lblNumPerson.AutoSize = true;
            this.lblNumPerson.Font = new System.Drawing.Font("굴림", 11F);
            this.lblNumPerson.Location = new System.Drawing.Point(591, 418);
            this.lblNumPerson.Name = "lblNumPerson";
            this.lblNumPerson.Size = new System.Drawing.Size(27, 26);
            this.lblNumPerson.TabIndex = 5;
            this.lblNumPerson.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(163, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "결제 인원:";
            // 
            // ucDucth2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblNumPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPricePerRound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRestofPrice);
            this.Controls.Add(this.label1);
            this.Name = "ucDucth2";
            this.Size = new System.Drawing.Size(915, 616);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblRestofPrice;
        public System.Windows.Forms.Label lblPricePerRound;
        public System.Windows.Forms.Label lblNumPerson;
    }
}

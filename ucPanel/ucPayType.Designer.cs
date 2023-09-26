
namespace Unicon1.ucPanel
{
    partial class ucPayType
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnKakao = new System.Windows.Forms.Button();
            this.btnNaver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(139, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "네이버페이";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(343, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "카카오페이";
            // 
            // btnKakao
            // 
            this.btnKakao.BackColor = System.Drawing.SystemColors.Control;
            this.btnKakao.FlatAppearance.BorderSize = 0;
            this.btnKakao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKakao.Image = global::Unicon1.Properties.Resources.kpay1;
            this.btnKakao.Location = new System.Drawing.Point(321, 65);
            this.btnKakao.Margin = new System.Windows.Forms.Padding(0);
            this.btnKakao.Name = "btnKakao";
            this.btnKakao.Size = new System.Drawing.Size(130, 130);
            this.btnKakao.TabIndex = 1;
            this.btnKakao.UseVisualStyleBackColor = false;
            // 
            // btnNaver
            // 
            this.btnNaver.BackColor = System.Drawing.SystemColors.Control;
            this.btnNaver.FlatAppearance.BorderSize = 0;
            this.btnNaver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaver.Image = global::Unicon1.Properties.Resources.npay2;
            this.btnNaver.Location = new System.Drawing.Point(118, 65);
            this.btnNaver.Margin = new System.Windows.Forms.Padding(0);
            this.btnNaver.Name = "btnNaver";
            this.btnNaver.Size = new System.Drawing.Size(130, 130);
            this.btnNaver.TabIndex = 0;
            this.btnNaver.UseVisualStyleBackColor = false;
            // 
            // ucPayType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKakao);
            this.Controls.Add(this.btnNaver);
            this.Name = "ucPayType";
            this.Size = new System.Drawing.Size(582, 352);
            this.Load += new System.EventHandler(this.ucPayType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNaver;
        private System.Windows.Forms.Button btnKakao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


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
            this.btnNaver = new System.Windows.Forms.Button();
            this.bntKakao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNaver
            // 
            this.btnNaver.BackColor = System.Drawing.SystemColors.Control;
            this.btnNaver.Location = new System.Drawing.Point(92, 103);
            this.btnNaver.Name = "btnNaver";
            this.btnNaver.Size = new System.Drawing.Size(159, 146);
            this.btnNaver.TabIndex = 0;
            this.btnNaver.Text = "네이버페이";
            this.btnNaver.UseVisualStyleBackColor = false;
            // 
            // bntKakao
            // 
            this.bntKakao.BackColor = System.Drawing.SystemColors.Control;
            this.bntKakao.Location = new System.Drawing.Point(320, 103);
            this.bntKakao.Name = "bntKakao";
            this.bntKakao.Size = new System.Drawing.Size(159, 146);
            this.bntKakao.TabIndex = 1;
            this.bntKakao.Text = "카카오페이";
            this.bntKakao.UseVisualStyleBackColor = false;
            // 
            // ucPayType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bntKakao);
            this.Controls.Add(this.btnNaver);
            this.Name = "ucPayType";
            this.Size = new System.Drawing.Size(582, 352);
            this.Load += new System.EventHandler(this.ucPayType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNaver;
        private System.Windows.Forms.Button bntKakao;
    }
}

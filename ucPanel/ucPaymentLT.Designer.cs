namespace Unicon1.ucPanel
{
    partial class ucPaymentLT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDirectInput = new System.Windows.Forms.Button();
            this.btnDutch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 82);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDirectInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDutch, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 82);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnDirectInput
            // 
            this.btnDirectInput.BackColor = System.Drawing.Color.White;
            this.btnDirectInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDirectInput.FlatAppearance.BorderSize = 0;
            this.btnDirectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectInput.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDirectInput.ForeColor = System.Drawing.Color.Orange;
            this.btnDirectInput.Location = new System.Drawing.Point(0, 0);
            this.btnDirectInput.Margin = new System.Windows.Forms.Padding(0);
            this.btnDirectInput.Name = "btnDirectInput";
            this.btnDirectInput.Size = new System.Drawing.Size(293, 82);
            this.btnDirectInput.TabIndex = 1;
            this.btnDirectInput.Text = "직접입력";
            this.btnDirectInput.UseVisualStyleBackColor = false;
            this.btnDirectInput.Click += new System.EventHandler(this.btnDirectInput_Click);
            // 
            // btnDutch
            // 
            this.btnDutch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDutch.FlatAppearance.BorderSize = 0;
            this.btnDutch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDutch.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDutch.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDutch.Location = new System.Drawing.Point(293, 0);
            this.btnDutch.Margin = new System.Windows.Forms.Padding(0);
            this.btnDutch.Name = "btnDutch";
            this.btnDutch.Size = new System.Drawing.Size(293, 82);
            this.btnDutch.TabIndex = 2;
            this.btnDutch.Text = "더치페이";
            this.btnDutch.UseVisualStyleBackColor = true;
            this.btnDutch.Click += new System.EventHandler(this.btnDutch_Click);
            // 
            // ucPaymentLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPaymentLT";
            this.Size = new System.Drawing.Size(586, 82);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDirectInput;
        private System.Windows.Forms.Button btnDutch;
    }
}

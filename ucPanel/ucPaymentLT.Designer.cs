﻿namespace Unicon1.ucPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDirectInput = new System.Windows.Forms.Button();
            this.btnDutch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDirectInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDutch, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDirectInput
            // 
            this.btnDirectInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDirectInput.Location = new System.Drawing.Point(60, 31);
            this.btnDirectInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDirectInput.Name = "btnDirectInput";
            this.btnDirectInput.Size = new System.Drawing.Size(257, 52);
            this.btnDirectInput.TabIndex = 1;
            this.btnDirectInput.Text = "직접입력";
            this.btnDirectInput.UseVisualStyleBackColor = true;
            this.btnDirectInput.Click += new System.EventHandler(this.btnDirectInput_Click);
            // 
            // btnDutch
            // 
            this.btnDutch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDutch.Location = new System.Drawing.Point(321, 31);
            this.btnDutch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDutch.Name = "btnDutch";
            this.btnDutch.Size = new System.Drawing.Size(259, 52);
            this.btnDutch.TabIndex = 2;
            this.btnDutch.Text = "더치페이";
            this.btnDutch.UseVisualStyleBackColor = true;
            this.btnDutch.Click += new System.EventHandler(this.btnDutch_Click);
            // 
            // ucPaymentLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucPaymentLT";
            this.Size = new System.Drawing.Size(582, 85);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDirectInput;
        private System.Windows.Forms.Button btnDutch;
    }
}

﻿namespace Unicon1.ucPanel
{
    partial class ucPlaceStatus
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
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.54546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tableLayoutPanel1.Controls.Add(this.btnChangeName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlaceName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxInput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeName.Location = new System.Drawing.Point(278, 0);
            this.btnChangeName.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(72, 50);
            this.btnChangeName.TabIndex = 0;
            this.btnChangeName.Text = "이름변경";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(278, 50);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlaceName.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlaceName.Location = new System.Drawing.Point(0, 0);
            this.lblPlaceName.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(278, 50);
            this.lblPlaceName.TabIndex = 2;
            this.lblPlaceName.Text = "label1";
            // 
            // tboxInput
            // 
            this.tboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxInput.Location = new System.Drawing.Point(3, 53);
            this.tboxInput.Multiline = true;
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(272, 44);
            this.tboxInput.TabIndex = 3;
            // 
            // ucPlaceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPlaceStatus";
            this.Size = new System.Drawing.Size(350, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.TextBox tboxInput;
    }
}

﻿namespace Unicon1.ucPanel
{
    partial class ucDetail
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutLT = new System.Windows.Forms.TableLayoutPanel();
            this.pMenuList = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.pLT = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBackTable = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDivPay = new System.Windows.Forms.Button();
            this.btnMixedPay = new System.Windows.Forms.Button();
            this.btnCashPay = new System.Windows.Forms.Button();
            this.btnCardPay = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPayWord = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.LayoutLT.SuspendLayout();
            this.pMenuList.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "디테일 화면입니다.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.LayoutLT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 444);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LayoutLT
            // 
            this.LayoutLT.ColumnCount = 1;
            this.LayoutLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutLT.Controls.Add(this.pMenuList, 0, 1);
            this.LayoutLT.Controls.Add(this.pLT, 0, 0);
            this.LayoutLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutLT.Location = new System.Drawing.Point(0, 0);
            this.LayoutLT.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutLT.Name = "LayoutLT";
            this.LayoutLT.RowCount = 2;
            this.LayoutLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LayoutLT.Size = new System.Drawing.Size(586, 444);
            this.LayoutLT.TabIndex = 0;
            this.LayoutLT.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pMenuList
            // 
            this.pMenuList.BackColor = System.Drawing.Color.LightGray;
            this.pMenuList.Controls.Add(this.textBoxResult);
            this.pMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMenuList.Location = new System.Drawing.Point(2, 90);
            this.pMenuList.Margin = new System.Windows.Forms.Padding(2);
            this.pMenuList.Name = "pMenuList";
            this.pMenuList.Size = new System.Drawing.Size(582, 352);
            this.pMenuList.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(16, 11);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(555, 326);
            this.textBoxResult.TabIndex = 0;
            // 
            // pLT
            // 
            this.pLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLT.Location = new System.Drawing.Point(2, 2);
            this.pLT.Margin = new System.Windows.Forms.Padding(2);
            this.pLT.Name = "pLT";
            this.pLT.Size = new System.Drawing.Size(582, 84);
            this.pLT.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.fpMenu, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(586, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(391, 444);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackTable, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 24);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(195, 24);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBackTable
            // 
            this.btnBackTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackTable.Location = new System.Drawing.Point(195, 0);
            this.btnBackTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackTable.Name = "btnBackTable";
            this.btnBackTable.Size = new System.Drawing.Size(196, 24);
            this.btnBackTable.TabIndex = 6;
            this.btnBackTable.Text = "돌아가기";
            this.btnBackTable.UseVisualStyleBackColor = true;
            this.btnBackTable.Click += new System.EventHandler(this.btnBackTable_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnDivPay, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnMixedPay, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnCashPay, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCardPay, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 370);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(387, 72);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // btnDivPay
            // 
            this.btnDivPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDivPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivPay.Location = new System.Drawing.Point(195, 38);
            this.btnDivPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivPay.Name = "btnDivPay";
            this.btnDivPay.Size = new System.Drawing.Size(190, 32);
            this.btnDivPay.TabIndex = 3;
            this.btnDivPay.Text = "분할결제";
            this.btnDivPay.UseVisualStyleBackColor = false;
            this.btnDivPay.Click += new System.EventHandler(this.btnDivPay_Click);
            // 
            // btnMixedPay
            // 
            this.btnMixedPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMixedPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMixedPay.Location = new System.Drawing.Point(2, 38);
            this.btnMixedPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnMixedPay.Name = "btnMixedPay";
            this.btnMixedPay.Size = new System.Drawing.Size(189, 32);
            this.btnMixedPay.TabIndex = 2;
            this.btnMixedPay.Text = "복합결제";
            this.btnMixedPay.UseVisualStyleBackColor = false;
            this.btnMixedPay.Click += new System.EventHandler(this.btnMixedPay_Click);
            // 
            // btnCashPay
            // 
            this.btnCashPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCashPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCashPay.Location = new System.Drawing.Point(195, 2);
            this.btnCashPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnCashPay.Name = "btnCashPay";
            this.btnCashPay.Size = new System.Drawing.Size(190, 32);
            this.btnCashPay.TabIndex = 1;
            this.btnCashPay.Text = "현금";
            this.btnCashPay.UseVisualStyleBackColor = false;
            this.btnCashPay.Click += new System.EventHandler(this.btnCashPay_Click);
            // 
            // btnCardPay
            // 
            this.btnCardPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCardPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardPay.Location = new System.Drawing.Point(2, 2);
            this.btnCardPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnCardPay.Name = "btnCardPay";
            this.btnCardPay.Size = new System.Drawing.Size(189, 32);
            this.btnCardPay.TabIndex = 0;
            this.btnCardPay.Text = "신용카드";
            this.btnCardPay.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.27649F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.646F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.lblPayWord, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalPrice, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 321);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(387, 45);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lblPayWord
            // 
            this.lblPayWord.AutoSize = true;
            this.lblPayWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPayWord.Font = new System.Drawing.Font("굴림", 15F);
            this.lblPayWord.Location = new System.Drawing.Point(2, 0);
            this.lblPayWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayWord.Name = "lblPayWord";
            this.lblPayWord.Size = new System.Drawing.Size(148, 45);
            this.lblPayWord.TabIndex = 0;
            this.lblPayWord.Text = "총결제금액:";
            this.lblPayWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Font = new System.Drawing.Font("굴림", 15F);
            this.lblTotalPrice.Location = new System.Drawing.Point(154, 0);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(192, 45);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(350, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "원";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpMenu
            // 
            this.fpMenu.AutoScroll = true;
            this.fpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpMenu.Location = new System.Drawing.Point(2, 26);
            this.fpMenu.Margin = new System.Windows.Forms.Padding(2);
            this.fpMenu.Name = "fpMenu";
            this.fpMenu.Size = new System.Drawing.Size(387, 291);
            this.fpMenu.TabIndex = 5;
            // 
            // ucDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucDetail";
            this.Size = new System.Drawing.Size(977, 444);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LayoutLT.ResumeLayout(false);
            this.pMenuList.ResumeLayout(false);
            this.pMenuList.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel LayoutLT;
        private System.Windows.Forms.Panel pMenuList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblPayWord;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel fpMenu;
        private System.Windows.Forms.Button btnDivPay;
        private System.Windows.Forms.Button btnMixedPay;
        private System.Windows.Forms.Button btnCashPay;
        private System.Windows.Forms.Button btnCardPay;
        private System.Windows.Forms.Panel pLT;
        private System.Windows.Forms.Button btnBackTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

namespace Unicon1.ucPanel
{
    partial class UserControl1
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnRice = new System.Windows.Forms.Button();
            this.btnBev = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSteak = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnBrunch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel3.Controls.Add(this.btnDrink, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSalad, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnRice, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBev, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSet, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSteak, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPasta, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBrunch, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(915, 149);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrink.Location = new System.Drawing.Point(651, 74);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(217, 75);
            this.btnDrink.TabIndex = 7;
            this.btnDrink.Text = "주류";
            this.btnDrink.UseVisualStyleBackColor = false;
            // 
            // btnSalad
            // 
            this.btnSalad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalad.Location = new System.Drawing.Point(434, 74);
            this.btnSalad.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(217, 75);
            this.btnSalad.TabIndex = 6;
            this.btnSalad.Text = "샐러드";
            this.btnSalad.UseVisualStyleBackColor = false;
            // 
            // btnRice
            // 
            this.btnRice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRice.Location = new System.Drawing.Point(217, 74);
            this.btnRice.Margin = new System.Windows.Forms.Padding(0);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(217, 75);
            this.btnRice.TabIndex = 5;
            this.btnRice.Text = "밥";
            this.btnRice.UseVisualStyleBackColor = false;
            // 
            // btnBev
            // 
            this.btnBev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBev.Location = new System.Drawing.Point(0, 74);
            this.btnBev.Margin = new System.Windows.Forms.Padding(0);
            this.btnBev.Name = "btnBev";
            this.btnBev.Size = new System.Drawing.Size(217, 75);
            this.btnBev.TabIndex = 4;
            this.btnBev.Text = "음료수";
            this.btnBev.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSet.Location = new System.Drawing.Point(651, 0);
            this.btnSet.Margin = new System.Windows.Forms.Padding(0);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(217, 74);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "세트메뉴";
            this.btnSet.UseVisualStyleBackColor = false;
            // 
            // btnSteak
            // 
            this.btnSteak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSteak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSteak.Location = new System.Drawing.Point(434, 0);
            this.btnSteak.Margin = new System.Windows.Forms.Padding(0);
            this.btnSteak.Name = "btnSteak";
            this.btnSteak.Size = new System.Drawing.Size(217, 74);
            this.btnSteak.TabIndex = 2;
            this.btnSteak.Text = "스테이크";
            this.btnSteak.UseVisualStyleBackColor = false;
            this.btnSteak.Click += new System.EventHandler(this.btnSteak_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPasta.Location = new System.Drawing.Point(217, 0);
            this.btnPasta.Margin = new System.Windows.Forms.Padding(0);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(217, 74);
            this.btnPasta.TabIndex = 1;
            this.btnPasta.Text = "파스타";
            this.btnPasta.UseVisualStyleBackColor = false;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnBrunch
            // 
            this.btnBrunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBrunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrunch.Location = new System.Drawing.Point(0, 0);
            this.btnBrunch.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrunch.Name = "btnBrunch";
            this.btnBrunch.Size = new System.Drawing.Size(217, 74);
            this.btnBrunch.TabIndex = 0;
            this.btnBrunch.Text = "브런치";
            this.btnBrunch.UseVisualStyleBackColor = false;
            this.btnBrunch.Click += new System.EventHandler(this.btnBrunch_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(915, 149);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnRice;
        private System.Windows.Forms.Button btnBev;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSteak;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnBrunch;
    }
}

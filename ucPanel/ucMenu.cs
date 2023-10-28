using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Unicon1.ucPanel
{
    public partial class ucMenu : UserControl
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public event menulist addlist;

        ucMenuStatus ucMenuStatus = new ucMenuStatus();
        public ucMenu(List<menu_info> menu)
        {
            InitializeComponent();
            for(int i = 0; i < menu.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Gainsboro;
                btn.Dock = DockStyle.Fill;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                btn.Location = new Point(10, 124);
                btn.Margin = new Padding(10, 15, 10, 15);
                btn.Name = "btn"+i.ToString();
                btn.Text = menu[i].name + "\r\n\r\n" + menu[i].price.ToString();
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Size = new Size(175, 79);
                btn.TabIndex = i;
                btn.UseVisualStyleBackColor = false;
                btn.Click += Btn_Click;
                tableLayoutPanel4.Controls.Add(btn);
            }
            for(int i = 0; i < tableLayoutPanel4.Controls.Count; i++)
            {
                IntPtr ip = CreateRoundRectRgn(0, 0, tableLayoutPanel4.Controls[i].Width, tableLayoutPanel4.Controls[i].Height, 15, 15);
                SetWindowRgn(tableLayoutPanel4.Controls[i].Handle, ip, true);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] t = btn.Text.Split(new string[] {"\r\n\r\n"}, StringSplitOptions.None);
            ucMenuStatus menuInfo = new ucMenuStatus();
            menuInfo.Menu = t[0];
            menuInfo.Detail = "";
            menuInfo.Price = int.Parse(t[1]);
            addlist(sender, menuInfo);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

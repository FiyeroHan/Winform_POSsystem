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
    public partial class ucSandwitch : UserControl
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public event menulist addlist;

        ucMenuStatus ucMenuStatus = new ucMenuStatus();
        public ucSandwitch()
        {
            InitializeComponent();
            for(int i = 0; i < tableLayoutPanel4.Controls.Count; i++)
            {
                IntPtr ip = CreateRoundRectRgn(0, 0, tableLayoutPanel4.Controls[i].Width, tableLayoutPanel4.Controls[i].Height, 15, 15);
                SetWindowRgn(tableLayoutPanel4.Controls[i].Handle, ip, true);
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "아메리칸 샌드위치";
            menuInfo.Detail = "토마토, 오이 없음";
            menuInfo.Price = 9000;


            addlist("button10", menuInfo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "스모크 돼지고기 샌드위치";
            menuInfo.Detail = "";
            menuInfo.Price = 9000;


            addlist("button9", menuInfo);
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "아보카도 샌드위치";
            menuInfo.Detail = "오이 없음";
            menuInfo.Price = 9000;


            addlist("btnTable1", menuInfo);
        }
    }
}

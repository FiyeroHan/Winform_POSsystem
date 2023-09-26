using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicon1.ucPanel
{
    public partial class ucDucth : UserControl
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        int numPerson = 0;

        public event floatDutch floatdutch;
        public ucDucth()
        {
            InitializeComponent();

            IntPtr ip = CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15);
            SetWindowRgn(button1.Handle, ip, true);

            ip = CreateRoundRectRgn(0, 0, btnPlus.Width, btnPlus.Height, 15, 15);
            SetWindowRgn(btnPlus.Handle, ip, true);

            ip = CreateRoundRectRgn(0, 0, btnMinus.Width, btnMinus.Height, 15, 15);
            SetWindowRgn(btnMinus.Handle, ip, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numPerson = int.Parse(tboxNum.Text);
            floatdutch("button1", numPerson);

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tboxNum.Text);
            if (num > 0) num--;
            tboxNum.Text = num.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tboxNum.Text);
            tboxNum.Text = (++num).ToString();
        }
    }
}

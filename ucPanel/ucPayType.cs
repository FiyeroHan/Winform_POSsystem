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
    public partial class ucPayType : UserControl
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public ucPayType()
        {
            InitializeComponent();
            IntPtr ip = CreateRoundRectRgn(0, 0, btnNaver.Width, btnNaver.Height, 15, 15);
            SetWindowRgn(btnNaver.Handle, ip, true);

            ip = CreateRoundRectRgn(0, 0, btnKakao.Width, btnKakao.Height, 15, 15);
            SetWindowRgn(btnKakao.Handle, ip, true);
        }

        private void ucPayType_Load(object sender, EventArgs e)
        {
        }
    }
}

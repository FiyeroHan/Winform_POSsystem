using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicon1.ucPanel
{
    public partial class UserControl1 : UserControl
    {
        public event floatmenu FloatMenu;
        ucSandwitch ucSandwitch = new ucSandwitch();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnBrunch_Click(object sender, EventArgs e)
        {
            foreach (Button btn in tableLayoutPanel3.Controls) btn.ForeColor = Color.Gray;
            btnBrunch.ForeColor = Color.Orange;
            FloatMenu("ucSandwitch", (MenuList)0);
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            foreach (Button btn in tableLayoutPanel3.Controls) btn.ForeColor = Color.Gray;
            btnPasta.ForeColor = Color.Orange;
            FloatMenu("ucPasta", (MenuList)1);
        }

        private void btnSteak_Click(object sender, EventArgs e)
        {
            foreach (Button btn in tableLayoutPanel3.Controls) btn.ForeColor = Color.Gray;
            btnSteak.ForeColor = Color.Orange;
            FloatMenu("ucSteak", (MenuList)2);
        }
    }
}

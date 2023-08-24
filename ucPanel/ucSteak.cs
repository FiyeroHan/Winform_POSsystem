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
    public partial class ucSteak : UserControl
    {
        public event menulist addlist;

        public ucSteak()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "안심 스테이크";
            menuInfo.Detail = "";
            menuInfo.Price = 17000;


            addlist("button10", menuInfo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "등심 스테이크";
            menuInfo.Detail = "";
            menuInfo.Price = 17000;


            addlist("button9", menuInfo);
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "목살 찹 스테이크";
            menuInfo.Detail = "";
            menuInfo.Price = 13000;


            addlist("btnTable1", menuInfo);
        }
    }
}

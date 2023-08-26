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
    public partial class ucPasta : UserControl
    {
        public event menulist addlist;

        public ucPasta()
        {
            InitializeComponent();
        }


        private void button10_Click_1(object sender, EventArgs e)
        {

            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "알리오 올리오";
            menuInfo.Detail = "";
            menuInfo.Price = 9000;


            addlist("button10", menuInfo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "토마토 파스타";
            menuInfo.Detail = "";
            menuInfo.Price = 11000;


            addlist("button9", menuInfo);
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            ucMenuStatus menuInfo = new ucMenuStatus();

            menuInfo.Menu = "크림 파스타";
            menuInfo.Detail = "";
            menuInfo.Price = 11000;


            addlist("btnTable1", menuInfo);
        }
    }
}

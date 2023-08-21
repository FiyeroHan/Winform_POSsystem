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
    public partial class ucDetail : UserControl
    {
        public event delLogSender eLogSender;

        public List<ucMenuStatus> table1_menu = new List<ucMenuStatus>();

        ucSandwitch ucSandwitch = new ucSandwitch();
        ucPasta ucPasta = new ucPasta();
        ucMenuStatus ucMenuStatus = new ucMenuStatus();
        ucPayment ucPayment = new ucPayment();
        ucPaymentLT ucPaymentLT = new ucPaymentLT();
        UserControl1 ucUserControl1 = new UserControl1();
        public int total_price = 0;

 //       ucMenuStatus[] menuList = new ucMenuStatus[20];

        public ucDetail()
        {
            InitializeComponent();
            ucSandwitch.addlist += UcSandwitch_addlist;
            pLT.Controls.Add(ucUserControl1);
            pMenuList.Controls.Add(ucSandwitch);
        }



        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(ucSandwitch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(ucPasta);
        }

        private void UcSandwitch_addlist(object oSender)
        {
            ucMenuStatus _ucMenuStatus = new ucMenuStatus();
            _ucMenuStatus.Menu = "아메리칸 샌드위치";
            _ucMenuStatus.Detail = "토마토, 오이 없음";
            _ucMenuStatus.Price = 9000;

            total_price += _ucMenuStatus.Price;
            lblTotalPrice.Text = total_price.ToString();
            table1_menu.Add(_ucMenuStatus);

            foreach (ucMenuStatus i in table1_menu)
            {
                fpMenu.Controls.Add(i);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pLT.Controls.Clear();
            pMenuList.Controls.Clear();

            pLT.Controls.Add(ucPaymentLT);
            pMenuList.Controls.Add(ucPayment);
        }

        //private void btnMixedPay_Click(object sender, EventArgs e)
        //{
        //    using (var dialog = new LoginDialog())
        //    {
        //        // this : Overlay밑에 깔릴 Form (MainForm)
        //        // dialog : Overlay위에 올라갈 Dialog
        //        if (OverlayDialog.ShowDialog(this, dialog) != DialogResult.OK) return;

        //        var user = dialog.LoginUser;
        //        // Do Something...
        //    }
        //        }
    }
}

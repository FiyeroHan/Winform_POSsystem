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

        ucSandwitch _ucSandwitch = new ucSandwitch();
        ucPasta _ucPasta = new ucPasta();
        ucSteak _ucSteak = new ucSteak();
        ucMenuStatus _ucMenuStatus = new ucMenuStatus();
        ucPayment _ucPayment = new ucPayment();
        ucPaymentLT _ucPaymentLT = new ucPaymentLT();
        UserControl1 _ucUserControl1 = new UserControl1();
        ucDucth _ucDutch = new ucDucth();
        ucDucth2 _ucDutch2 = new ucDucth2();

        public int total_price = 0;


 //       ucMenuStatus[] menuList = new ucMenuStatus[20];

        public ucDetail()
        {
            InitializeComponent();
            _ucSandwitch.addlist += Add_status;
            _ucUserControl1.FloatMenu += fMenulist;
            _ucPaymentLT.floatPayment += fPaymentPage;
            _ucDutch.floatdutch += fDutch;

            pLT.Controls.Clear();
            pLT.Controls.Add(_ucUserControl1);
        }



        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_status(object oSender, ucMenuStatus menuInfo)
        {

            total_price += menuInfo.Price;
            lblTotalPrice.Text = total_price.ToString();
            table1_menu.Add(menuInfo);

            foreach (ucMenuStatus i in table1_menu)
            {
                fpMenu.Controls.Add(i);
            }
        }

        private void fMenulist(object oSender,MenuList menu)
        {
            switch (menu)
            {
                case (MenuList.Sandwitch):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucSandwitch);
                    break;
                case (MenuList.Pasta):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucPasta);
                    break;
                case (MenuList.Steak):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucSteak);
                    break;

            }
                
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(_ucPayment);

            pLT.Controls.Clear();
            pLT.Controls.Add(_ucPaymentLT);

        }

        private void fPaymentPage(object oSender, string page)
        {
            switch (page)
            {
                case ("direct"):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucPayment);
                    break;
                case ("dutch"):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucDutch);
                    break;
            }
        }

        private void fDutch(object oSender, int numPerson)
        {
            int n = 0;
            int Priceper1 = total_price / numPerson;
            int restofPrice = total_price - Priceper1*n;
            _ucDutch2.lblPricePerRound.Text = Priceper1.ToString();
            _ucDutch2.lblRestofPrice.Text = restofPrice.ToString();
            _ucDutch2.lblNumPerson.Text = numPerson.ToString();

            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(_ucDutch2);
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

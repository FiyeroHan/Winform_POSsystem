using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Unicon1.ucPanel
{
    public partial class ucDetail : UserControl
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string apiUserListUrl = "http://hoshi-kirby.xyz/api/v1/user/list";
        private readonly string apiOrderListUrl = "http://hoshi-kirby.xyz/api/v1/order/list";

        public event backToTable BackToTable;

        Form1 _form1 = new Form1();
        ucSandwitch _ucSandwitch = new ucSandwitch();
        ucPasta _ucPasta;
        ucSteak _ucSteak = new ucSteak();
        ucMenuStatus _ucMenuStatus = new ucMenuStatus();
        
        ucPaymentLT _ucPaymentLT = new ucPaymentLT();
        UserControl1 _ucUserControl1 = new UserControl1();
        ucDucth _ucDutch = new ucDucth();
        ucDucth2 _ucDutch2 = new ucDucth2();
        ucPayType _ucPayType = new ucPayType();
        ucPayTypeLT _ucPayTypeLT = new ucPayTypeLT();
        

        string _token = string.Empty;
        List<string> _storecode = new List<string>();

        private List<ucMenuStatus> _table = new List<ucMenuStatus>();

        public int total_price = 0;
        public int payed_price = 0;
        public int tableNum = 0;
        public int place = 0;


        //       ucMenuStatus[] menuList = new ucMenuStatus[20];

        public ucDetail(List<ucMenuStatus> table, int payed_price, int tableNum, int place)
        {
            this.tableNum = tableNum;
            _table = table;
            this.payed_price = payed_price;
            this.place = place;
            Console.WriteLine(payed_price.ToString());
            InitializeComponent();
            
            _ucSandwitch.addlist += Add_status;
            _ucSteak.addlist += Add_status;
            _ucUserControl1.FloatMenu += fMenulist;
            _ucPaymentLT.floatPayment += fPaymentPage;
            _ucPaymentLT.backToMenu += BackToMenu;
            _ucPayTypeLT.backToMenu += BackToMenu;
            _ucDutch.floatdutch += fDutch;
            _form1.AccessToken += foo;

            pLT.Controls.Clear();
            pLT.Controls.Add(_ucUserControl1);

            total_price = 0;

            foreach (ucMenuStatus i in _table)
            {
                fpMenu.Controls.Add(i);
                total_price += i.Price;
                i.removelist += fRemove;
            }

            lblTotalPrice.Text = total_price.ToString();

            string apiUrl = "http://hoshi-kirby.xyz/api/v1/order/store/list";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                string responseFromServer = string.Empty;
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.PreAuthenticate = true;
                //request.Headers.Add("Authorization", "Bearer " + _token);
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                    responseFromServer = reader.ReadToEnd();
                JObject jobect = JObject.Parse(responseFromServer);
                JToken jtoken = jobect["stores"];
                foreach (JToken token in jtoken)
                {
                    _storecode.Add(token["store_code"].ToString());
                    textBoxResult.Text += token["store_code"].ToString() + "\r\n";
                }
                //textBoxResult.Text += jtoken.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.WriteLine(_storecode[0]);
            
        }


        private void _ucPayment_inputprice(object sender, int price)
        {
            lblTotalPrice.Text = price.ToString();
        }

        public void setToken(string token)
        {
            _token = token;
        }

        public int getTotalPrice()
        {
            return total_price;
        }

        private void foo(object sender)
        {
            /*string apiUrl = "http://hoshi-kirby.xyz/api/v1/order/store/list";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                string responseFromServer = string.Empty;
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.PreAuthenticate = true;
                //request.Headers.Add("Authorization", "Bearer " + _token);
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                    responseFromServer = reader.ReadToEnd();
                JObject jobect = JObject.Parse(responseFromServer);
                JToken jtoken = jobect["stores"];
                foreach(JToken token in jtoken)
                {
                    _storecode.Add(token["store_code"].ToString());
                    textBoxResult.Text += token["store_code"].ToString()+"\r\n";
                }
                //textBoxResult.Text += jtoken.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            
        }

        private void BackToMenu(object sender)
        {
            pMenuList.Controls.Clear();

            pLT.Controls.Clear();
            pLT.Controls.Add(_ucUserControl1);

            lblPayWord.Text = "총결제금액:";
            lblTotalPrice.Text = total_price.ToString();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_status(object oSender, ucMenuStatus menuInfo)
        {
            menuInfo.removelist += fRemove;
            total_price += menuInfo.Price;
            lblTotalPrice.Text = total_price.ToString();
            _table.Add(menuInfo);

            foreach (ucMenuStatus i in _table)
            {
                fpMenu.Controls.Add(i);
            }
        
        }

        public void AddStatusFromOrder(object oSender, ucMenuStatus menuInfo)
        {

        }

        private void fRemove(object oSender, ucMenuStatus menuInfo)
        {
            total_price -= menuInfo.Price;
            lblTotalPrice.Text = total_price.ToString();
            _table.Remove(menuInfo);
            fpMenu.Controls.Clear();

            foreach (ucMenuStatus i in _table)
            {
                fpMenu.Controls.Add(i);
            }
        }

        private void fMenulist(object oSender, MenuList menu)
        {
            switch (menu)
            {
                case (MenuList.Sandwitch):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucSandwitch);
                    break;
                case (MenuList.Pasta):
                    _ucPasta = new ucPasta(_storecode[0]);
                    _ucPasta.addlist += Add_status;
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucPasta);
                    break;
                case (MenuList.Steak):
                    pMenuList.Controls.Clear();
                    pMenuList.Controls.Add(_ucSteak);
                    break;

            }

        }

        private void btnDivPay_Click(object sender, EventArgs e)
        {
            ucPayment _ucPayment = new ucPayment(total_price, payed_price);
            _ucPayment.inputprice += _ucPayment_inputprice;
            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(_ucPayment);
            
            pLT.Controls.Clear();
            pLT.Controls.Add(_ucPaymentLT);

            lblPayWord.Text = "이번결제금액:";
            lblTotalPrice.Text = "0";
        }

        private void fPaymentPage(object oSender, string page)
        {
            switch (page)
            {
                case ("direct"):
                    ucPayment _ucPayment = new ucPayment(total_price, payed_price);
                    _ucPayment.inputprice += _ucPayment_inputprice;
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
            int restofPrice = total_price - Priceper1 * n;
            _ucDutch2.lblPricePerRound.Text = Priceper1.ToString();
            _ucDutch2.lblRestofPrice.Text = restofPrice.ToString();
            _ucDutch2.lblNumPerson.Text = numPerson.ToString();

            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(_ucDutch2);
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackTable_Click(object sender, EventArgs e)
        {
            BackToTable(sender, _table, payed_price, place, tableNum);
        }

        private void btnMixedPay_Click(object sender, EventArgs e)
        {
            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(_ucPayType);

            pLT.Controls.Clear();
            pLT.Controls.Add(_ucPayTypeLT);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pLT.Controls.Clear();
            pMenuList.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            _ucUserControl1 = userControl1;
            pLT.Controls.Add(_ucUserControl1);
            _ucUserControl1.FloatMenu += fMenulist;
        }

        private void btnCashPay_Click(object sender, EventArgs e)
        {
            if(pMenuList.Controls.Count == 0) { return; }
            foreach (Control c in pMenuList.Controls)
            {
                if (c == _ucPasta || c == _ucSandwitch || c == _ucSteak || c == textBoxResult) return;
            }
            payed_price += int.Parse(lblTotalPrice.Text);
            lblTotalPrice.Text = "0";
            ucPayment _ucPayment = new ucPayment(total_price, payed_price);
            _ucPayment.inputprice += _ucPayment_inputprice;
            pMenuList.Controls.Clear();
            pMenuList.Controls.Add(_ucPayment);
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
        
        
        /// <summary>
        /// 주문이 들어왔을때 실행해서 변수에 집어넣는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private async void Ordered(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        WebRequest request = WebRequest.Create(apiOrderListUrl);
        //        string responseFromServer = string.Empty;
        //        request.Method = "GET";
        //        request.ContentType = "application/json";
        //        using (WebResponse response = request.GetResponse())
        //        using (Stream dataStream = response.GetResponseStream())
        //        using (StreamReader reader = new StreamReader(dataStream))
        //            responseFromServer = reader.ReadToEnd();
        //        JObject jobect = JObject.Parse(responseFromServer);
        //        JToken jtoken = jobect["data"];
        //        foreach (JToken token in jtoken) textBoxResult.Text += token["user_name"].ToString() + "\r\n";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
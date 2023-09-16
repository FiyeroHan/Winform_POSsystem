using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicon1.ucPanel;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

namespace Unicon1
{
    public partial class Form1 : Form
    {
        public event passtoken AccessToken;

        ucPanel.ucTable ucTable = new ucPanel.ucTable();
        ucPanel.ucLogin ucLogin = new ucPanel.ucLogin();
        ucPanel.ucSetting ucSetting = new ucSetting();

        List<ucMenuStatus>[,] _tableMenuList = new List<ucMenuStatus>[20, 100];
        int[,] _tablePayedPrice = new int[30, 100];

        string _token = string.Empty;

        public Form1()
        {
            InitializeComponent();
        
        }

        private Form1(Form parent,double opacity)
        {
            FormBorderStyle = FormBorderStyle.None;

            //불투명 색상
            BackColor = Color.Black;

            //불투명 정도, 0에 가까울수록 투명
            Opacity = opacity;

            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Size = parent.ClientSize;
            Location = parent.PointToScreen(Point.Empty);

        }  

        public static DialogResult ShowDialog(Form parent, Form dialog, double opacity = 0.65)
        {
            var background = new Form1(parent, opacity);
            background.MdiParent = parent.MdiParent;
            background.Show();

            dialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = dialog.ShowDialog(background);
            background.Close();
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin.LoginSuccess += UcLogin_LoginSuccess;
            pMain.Controls.Add(ucLogin);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 100; j++) _tableMenuList[i, j] = new List<ucMenuStatus>();
            }
            ucTable = new ucPanel.ucTable();
        }

        private void UcLogin_LoginSuccess(object sender, JToken token)
        {
            pMain.Controls.Remove(ucLogin);
                ucTable.FloatDetail += fDetail;
                ucTable.setting += UcTable_setting;
                ucTable.changePlace += UCTable_ChangePlace;

            pMain.Controls.Add(ucTable);
            _token = token.ToString();
            ucSetting.endSetting += UcSetting_endSetting;
            ucSetting.changePlace += UcSetting_changePlace;
        }

        private void UcSetting_changePlace(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place)
        {
            Button btn = sender as Button;
            place = int.Parse(btn.Name.Substring(8));
            pMain.Controls.Clear();
            pMain.Controls.Add(ucSetting);
            ucSetting.SetTable(_tableStatus, _placeStatus, place);
        }

        private void UCTable_ChangePlace(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place)
        {
            Button btn = sender as Button;
            place = int.Parse(btn.Name.Substring(8));
            pMain.Controls.Clear();
            pMain.Controls.Add(ucTable);
            ucTable.ShowTable(_tableStatus, _placeStatus, place);
        }

        private void UcTable_setting(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(ucSetting);
            ucSetting.SetTable(_tableStatus, _placeStatus, place);
        }

        private void UcSetting_endSetting(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(ucTable);
            ucTable.ShowTable(_tableStatus, _placeStatus, place);
        }

        private void fDetail(object oSender, int place)
        {
            Button btn = oSender as Button;
            int tableNum = int.Parse(btn.Name.Substring(8));
            ucPanel.ucDetail ucDetail = new ucPanel.ucDetail(_tableMenuList[place, tableNum], _tablePayedPrice[place, tableNum], place, tableNum);
            ucDetail.setToken(_token);
            ucDetail.BackToTable += fTable;

            pMain.Controls.Clear();
            pMain.Controls.Add(ucDetail);


        }

        private void fTable(object oSender, List<ucPanel.ucMenuStatus> table, int payed_price, int tableNum, int place ) 
        {
            _tableMenuList[place, tableNum] = table;
            _tablePayedPrice[place, tableNum] = payed_price;
            pMain.Controls.Clear();
            pMain.Controls.Add(ucTable);
        }

        /*public void callValues(object tableNum, object price, object name, object detail)
        {
            int itableNum = (int)tableNum;
            int iprice = (int)price;
            string sname = (string)name;
            string sdetail = (string)detail;

            ucPanel.ucMenuStatus menuinfo = new ucPanel.ucMenuStatus(iprice, sname, sdetail);
            
            switch (itableNum)
            {
                case 1:
                    ucTable.table1.Add(menuinfo);
                    break;
                case 2:
                    ucTable.table1.Add(menuinfo);
                    break;
                case 3:
                    ucTable.table1.Add(menuinfo);
                    break;
                case 4:
                    ucTable.table1.Add(menuinfo);
                    break;
                case 5:
                    ucTable.table1.Add(menuinfo);
                    break;
                case 6:
                    ucTable.table1.Add(menuinfo);
                    break;
                case 7:
                    ucTable.table1.Add(menuinfo);
                    break;
            }

        }*/

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

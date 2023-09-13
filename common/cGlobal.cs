using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicon1.ucPanel;

namespace Unicon1
{
    internal class cGlobal
    {

    }

    // UserControl에서 Main으로 Log를 전달 하기 위한 Delegate
    public delegate void floatDetail(object oSende);
    public delegate void backToTable(object oSende, List<ucPanel.ucMenuStatus> table, int payed_price, int tableNum);
    public delegate void endSetting(object sender, Button[] _tableStatus);
    public delegate void menulist(object oSender, ucPanel.ucMenuStatus menuInfo);
    public delegate void floatmenu(object oSender, MenuList menu);
    public delegate void floatPayment(object oSender, string page);
    public delegate void floatDutch(object oSender, int num);
    public delegate void backToMenu(object sender);
    public delegate void login(object sender, JToken token);
    public delegate void passtoken(object sender);
    public delegate void passprice(object sender, int price);
    public delegate void setting(object sender, Button[] _tableStatus);
    

    struct menu_info
    {
        public string name;
        public int price;
    }

    public enum MenuList
    {
        Sandwitch,
        Pasta,
        Steak,
        Set,
        Beverage,
        Rice,
        Salad,
        Drinks
    }


}

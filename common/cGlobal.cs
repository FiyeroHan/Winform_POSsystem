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

    public struct menu_info
    {
        public string name;
        public string describe;
        public int price;
    }

    // UserControl에서 Main으로 Log를 전달 하기 위한 Delegate
    public delegate void floatDetail(object oSende, int place);
    public delegate void backToTable(object oSende, List<ucPanel.ucMenuStatus> table, int payed_price, int place, int tableNum);
    public delegate void endSetting(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place);
    public delegate void menulist(object oSender, ucPanel.ucMenuStatus menuInfo);
    public delegate void floatmenu(object oSender, List<menu_info> menu);
    public delegate void floatPayment(object oSender, string page);
    public delegate void floatDutch(object oSender, int num);
    public delegate void backToMenu(object sender);
    public delegate void login(object sender);
    public delegate void passtoken(object sender);
    public delegate void passprice(object sender, int price);
    public delegate void setting(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place);
    public delegate void changePlace(object sender, Button[,] _tableStatus, Button[] _placeStatus, int place);
    public delegate void placeSetting(object sender, Button[,] tableStatus, Button[] placeStatus, int place);
    public delegate void endPlaceSetting(object sender, Button[,] tableStatus, Button[] placeStatus, List<ucMenuStatus>[,] tableMenuList, int[,] tablePayedPrice);
    public delegate void deletePlace(object sender, ucPlaceStatus ucPlaceStatus);
    

    

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

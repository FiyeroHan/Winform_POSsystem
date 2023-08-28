using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicon1
{
    internal class cGlobal
    {

    }

    // UserControl에서 Main으로 Log를 전달 하기 위한 Delegate
    public delegate void floatDetail(object oSende, List<ucPanel.ucMenuStatus> table);
    public delegate void backToTable(object oSende, List<ucPanel.ucMenuStatus> table);
    public delegate void menulist(object oSender, ucPanel.ucMenuStatus menuInfo);
    public delegate void floatmenu(object oSender, MenuList menu);
    public delegate void floatPayment(object oSender, string page);
    public delegate void floatDutch(object oSender, int num);

    

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

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
    public delegate void delLogSender(object oSender);
    public delegate void menulist(object oSender);

    struct menu_info
    {
        public string name;
        public int price;
    }


}

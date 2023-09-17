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
    public partial class ucPlaceSetting : UserControl
    {
        public event endPlaceSetting endPlaceSetting;
        Button[] _placeStatus = new Button[30];
        Button[,] _tableStatus = new Button[30, 30];
        List<ucMenuStatus>[,] _tableMenuList = new List<ucMenuStatus>[20, 100];
        int[,] _tablePayedPrice = new int[30, 100];

        public ucPlaceSetting(Button[,] tableStatus, Button[] placeStatus, List<ucMenuStatus>[,] tableMenuList, int[,] tablePayedPrice)
        {
            InitializeComponent();
            _placeStatus = placeStatus;
            _tableStatus = tableStatus;
            _tableMenuList = tableMenuList;
            _tablePayedPrice = tablePayedPrice;  
            _placeStatus = placeStatus;
            fpPlace.Controls.Clear();
            for (int i = 1; i < 14; i++)
            {
                Button btn = placeStatus[i];
                if (btn.Text == "+" || btn.Text == "") continue;
                ucPlaceStatus ucPlaceStatus = new ucPlaceStatus(btn.Text, btn.Name);
                fpPlace.Controls.Add(ucPlaceStatus);
                ucPlaceStatus.deletePlace += UcPlaceStatus_deletePlace;
            }
        }

        private void UcPlaceStatus_deletePlace(object sender, ucPlaceStatus ucPlaceStatus)
        {
            if(fpPlace.Controls.Count > 1)
            {
                foreach(ucPlaceStatus ucps in fpPlace.Controls)
                {
                    if (ucps == ucPlaceStatus)
                    {
                        ucps.Dispose();
                        break;
                    }
                    
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            int idx = 1;
            foreach(ucPlaceStatus ucps in fpPlace.Controls) {
                Button btn = new Button();
                btn.Text = ucps.placeName;
                btn.Name = "btnPlace" + idx.ToString();
                _placeStatus[idx] = btn;
                int place = int.Parse(ucps.btnName.Substring(8));
                for(int i = 1; i < 25; i++)
                {
                    Console.WriteLine(_tableStatus[idx, i].Name + " " + _tableStatus[place, i].Name + " " + _tablePayedPrice[idx, i].ToString() + " " + _tablePayedPrice[place, i].ToString());
                    _tableStatus[idx, i].Text = _tableStatus[place, i].Text;
                    _tableStatus[idx, i].Name = _tableStatus[place, i].Name;
                    _tableMenuList[idx, i] = _tableMenuList[place, i];
                    _tablePayedPrice[idx, i] = _tablePayedPrice[place, i];
                }
                Console.WriteLine(idx.ToString() + " " + place.ToString());
                idx++;
            }
            for(int i = idx; i < 14; i++)
            {
                Console.WriteLine(i.ToString());
                _placeStatus[i].Text = "";
                _placeStatus[i].Name = "btnPlace" + i.ToString();
                for(int j = 1; j < 25; j++)
                {
                    _tableStatus[i, j].Name = "btnEmpty" + j.ToString();
                    _tableMenuList[i, j] = new List<ucMenuStatus>();
                    _tablePayedPrice[i, j] = 0;
                }
            }
            endPlaceSetting(sender, _tableStatus, _placeStatus, _tableMenuList, _tablePayedPrice);
        }
    }
}

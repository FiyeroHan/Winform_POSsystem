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
    public partial class ucTable : UserControl
    {
        public event setting setting;
        public event floatDetail FloatDetail;
        public event changePlace changePlace;

        public Button[,] _tableStatus = new Button[30, 30];
        public Button[] _placeStatus = new Button[30];
        int place = 1;

        public ucTable()
        {
            InitializeComponent();
            for (int i = 1; i < 14; i++)
            {
                for(int j = 1; j < 25; j++)
                {
                    Button btn = new Button();
                    btn.Text = "+";
                    btn.Name = "btnEmpty" + j.ToString();
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.Transparent;
                    btn.Click += Btn_Click;
                    _tableStatus[i, j] = btn;
                }
            }
            for (int i = 1; i < 14; i++)
            {
                Button btn = new Button();
                btn.Text = "";
                btn.Name = "btnPlace" + i.ToString();
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Transparent;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.Click += ChangePlace;
                _placeStatus[i] = btn;
                pPlace.Controls.Add(btn);
            }
        }

        private void ChangePlace(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if(btn.Text != "")
            {
                place = int.Parse(btn.Name.Substring(8));
                changePlace(sender, _tableStatus, _placeStatus, place);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, place);
        }

        public void ShowTable(Button[,] _tableStatus, Button[] _placeStatus, int place)
        {
            this.place = place;
            pPlace.Controls.Clear();
            for(int i = 1; i < 14; i++)
            {
                Button btn = new Button();
                btn.Text = _placeStatus[i].Text == "+" ? "" : _placeStatus[i].Text;
                btn.Name = _placeStatus[i].Name;
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = i == place ? (btn.Text == "" ? Color.Transparent : Color.White) : Color.Transparent;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = i == place ? (btn.Text == "" ? Color.Transparent : Color.White) : Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = i == place ? (btn.Text == "" ? Color.Transparent : Color.White) : Color.Transparent;
                btn.Click += ChangePlace;
                this._placeStatus[i] = btn;
                pPlace.Controls.Add(this._placeStatus[i]);
            }

            pTable.Controls.Clear();
            for (int i = 1; i < 14; i++)
            {
                for(int j = 1; j < 25; j++)
                {
                    if (_tableStatus[i, j].Name.Substring(0, 8) == "btnEmpty")
                    {
                        Button btn = new Button();
                        btn.Text = " ";
                        btn.Name = "btnEmpty" + j.ToString();
                        btn.Dock = DockStyle.Fill;
                        btn.BackColor = Color.Transparent;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        this._tableStatus[i, j] = btn;
                    }
                    else
                    {
                        Button btn = new Button();
                        btn.Text = _tableStatus[i, j].Text;
                        btn.Name = _tableStatus[i, j].Name;
                        btn.Dock = DockStyle.Fill;
                        btn.BackColor = Color.White;
                        btn.Click += Btn_Click;
                        this._tableStatus[i, j] = btn;
                        
                    }
                    if(i == place) pTable.Controls.Add(this._tableStatus[i, j]);
                }
            }
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            setting(sender, _tableStatus, _placeStatus, 1);
        }
    }
}

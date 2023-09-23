using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Unicon1.ucPanel
{
    public partial class ucSetting : UserControl
    {
        public event endSetting endSetting;
        public event changePlace changePlace;
        public event placeSetting placeSetting;

        Button[,] _tableStatus = new Button[30, 30];
        Button[] _placeStatus = new Button[30];
        int _madeCount = 1;
        int place = 1;

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public ucSetting()
        {
            InitializeComponent();

            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Height = 2;
            lbl.Dock = DockStyle.Bottom;
            lbl.Name = "lbl1";
            lbl.BackColor = Color.Orange;
            panel1.Controls.Add(lbl);

            for (int i = 1; i < 14; i++)
            {
                for(int j = 1; j < 25; j++)
                {
                    Button btn = new Button();
                    btn.Text = "+";
                    btn.Name = "btnEmpty" + j.ToString();
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.Gainsboro;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += AddTable;
                    _tableStatus[i,j] = btn;
                }
            }
            for(int i = 1; i < 14; i++)
            {
                Button btn = new Button();
                btn.Text = i == 1 ? "1" : i == 2 ? "+" : "";
                btn.Name = "btnPlace" + i.ToString();
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = i == 1 ? Color.White : Color.Transparent;
                btn.FlatAppearance.MouseDownBackColor = i == 1 ? Color.White : Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = i == 1 ? Color.White : Color.Transparent;
                btn.Click += AddPlace;
                _placeStatus[i] = btn;
                pPlace.Controls.Add(btn);
            }
        }

        private void AddPlace(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text != "")
            {
                if(btn.Text == "+")
                {
                    btn.Text = btn.Name.Substring(8);
                    _placeStatus[int.Parse(btn.Name.Substring(8))] = btn;
                    if(int.Parse(btn.Name.Substring(8)) < 13) _placeStatus[int.Parse(btn.Name.Substring(8)) + 1].Text = "+";
                }
                else
                {
                    place = int.Parse(btn.Name.Substring(8));
                    changePlace(sender, _tableStatus, _placeStatus, int.Parse(btn.Name.Substring(8)));
                }
            }
        }

        private void AddTable(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Name.Substring(0,8) == "btnEmpty")
            {
                int tableIndex = int.Parse(btn.Name.Substring(8));
                btn.Text = _madeCount.ToString();
                btn.Name = "btnTable" + _madeCount++.ToString();
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.DarkGray;
                btn.Click += DeleteTable;
                _tableStatus[place, tableIndex] = btn;
                pTable.Controls.Clear();
                for(int i = 1; i < 25; i++)
                {
                    pTable.Controls.Add(_tableStatus[place, i]);
                    IntPtr ip = CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 15, 15);
                    SetWindowRgn(btn.Handle, ip, true);
                }
            }
        }

        public void SetTable(Button[,] _tableStatus, Button[] _placeStatus, int place)
        {
            this.place = place;
            bool isEnd = false;
            pPlace.Controls.Clear();
            for(int i = 1; i < 14; i++)
            {
                Button btn = new Button();
                if (!isEnd && (_placeStatus[i].Text == "" || _placeStatus[i].Text == "+"))
                {
                    isEnd = true;
                    btn.Text = "+";
                }
                else btn.Text = _placeStatus[i].Text;
                btn.Name = _placeStatus[i].Name;
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Transparent;
                btn.ForeColor = i == place ? Color.Orange : Color.DarkGray;
                btn.Font = new Font("맑은 고딕", 11);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.Click += AddPlace;
                this._placeStatus[i] = btn;
                pPlace.Controls.Add(this._placeStatus[i]);
            }
            pTable.Controls.Clear();
            for(int i = 1; i < 14; i++)
            {
                Console.WriteLine();
                for(int j = 1; j < 25; j++)
                {
                    Console.WriteLine(_tableStatus[i, j].Name);
                    Button btn = new Button();
                    if (_tableStatus[i, j].Name.Substring(0, 8) == "btnEmpty")
                    {
                        btn.Text = "+";
                        btn.Name = "btnEmpty" + j.ToString();
                        btn.Dock = DockStyle.Fill;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.Gainsboro;
                        btn.Click += AddTable;
                        this._tableStatus[i, j] = btn;
                    }
                    else
                    {
                        btn.Text = _tableStatus[i, j].Text;
                        btn.Name = _tableStatus[i, j].Name;
                        btn.Dock = DockStyle.Fill;
                        btn.BackColor = Color.DarkGray;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Click += DeleteTable;
                        this._tableStatus[i, j] = btn;
                    }
                    if (i == place)
                    {
                        pTable.Controls.Add(this._tableStatus[i, j]);
                        IntPtr ip = CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 15, 15);
                        SetWindowRgn(btn.Handle, ip, true);
                    }
                    
                }
            }
        }

        private void DeleteTable(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name.Substring(0, 8) == "btnTable")
            {
                for(int i = 1; i < 25; i++)
                {
                    if (_tableStatus[place, i] == btn)
                    {
                        _tableStatus[place, i].BackColor = _tableStatus[place, i].BackColor == Color.Black ? Color.White : Color.Black;
                    }
                }
                pTable.Controls.Clear();
                for (int i = 1; i < 25; i++)
                {
                    pTable.Controls.Add(_tableStatus[place, i]);
                }
            }
        }

        private void btnendSetting_Click(object sender, EventArgs e)
        {
            endSetting(sender, _tableStatus, _placeStatus, 1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 25; i++)
            {
                if (_tableStatus[place, i].BackColor == Color.Black)
                {
                    Button btn = new Button();
                    btn.Text = "+";
                    btn.Name = "btnEmpty" + i.ToString();
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.Gainsboro;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += AddTable;
                    
                    _tableStatus[place, i] = btn;
                }
            }
            pTable.Controls.Clear();
            for(int i = 1; i < 25; i++)
            {
                pTable.Controls.Add(_tableStatus[place, i]);
                IntPtr ip = CreateRoundRectRgn(0, 0, _tableStatus[place, i].Width, _tableStatus[place, i].Height, 15, 15);
                SetWindowRgn(_tableStatus[place, i].Handle, ip, true);
            }
        }

        private void btnPlaceSetting_Click(object sender, EventArgs e)
        {
            placeSetting(sender, _tableStatus, _placeStatus, 1);
        }
    }
}

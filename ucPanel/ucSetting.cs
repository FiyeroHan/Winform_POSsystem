using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Unicon1.ucPanel
{
    public partial class ucSetting : UserControl
    {
        public event endSetting endSetting;

        Button[] _tableStatus = new Button[30];
        int _madeCount = 1;

        public ucSetting()
        {
            InitializeComponent();
            for(int i = 1; i < 25; i++)
            {
                Button btn = new Button();
                btn.Text = "+";
                btn.Name = "btnEmpty" + i.ToString();
                btn.Dock = DockStyle.Fill;
                btn.BackColor = Color.Transparent;
                btn.Click += AddTable;
                _tableStatus[i] = btn;
                pTable.Controls.Add(btn);
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
                btn.BackColor = Color.White;
                btn.Click += DeleteTable;
                _tableStatus[tableIndex] = btn;
                pTable.Controls.Clear();
                for(int i = 1; i < 25; i++)
                {
                    pTable.Controls.Add(_tableStatus[i]);
                }
            }
        }

        public void SetTable(Button[] _tableStatus)
        {
            pTable.Controls.Clear();
            for(int i = 1; i < 25; i++)
            {
                Button btn = new Button();
                if (_tableStatus[i].Name.Substring(0, 8) == "btnEmpty")
                {
                    
                    btn.Text = "+";
                    btn.Name = "btnEmpty" + i.ToString();
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.Transparent;
                    btn.Click += AddTable;
                    this._tableStatus[i] = btn;
                }
                else
                {
                    btn.Text = _tableStatus[i].Text;
                    btn.Name = _tableStatus[i].Name;
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.White;
                    btn.Click += DeleteTable;
                    this._tableStatus[i] = btn;
                }
                pTable.Controls.Add(this._tableStatus[i]);
            }
        }

        private void DeleteTable(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name.Substring(0, 8) == "btnTable")
            {
                for(int i = 1; i < 25; i++)
                {
                    if (_tableStatus[i] == btn)
                    {
                        _tableStatus[i].BackColor = _tableStatus[i].BackColor == Color.Black ? Color.White : Color.Black;
                    }
                }
                pTable.Controls.Clear();
                for (int i = 1; i < 25; i++)
                {
                    pTable.Controls.Add(_tableStatus[i]);
                }
            }
        }

        private void btnendSetting_Click(object sender, EventArgs e)
        {
            endSetting(sender, _tableStatus);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 25; i++)
            {
                if (_tableStatus[i].BackColor == Color.Black)
                {
                    Button btn = new Button();
                    btn.Text = "+";
                    btn.Name = "btnEmpty" + i.ToString();
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.Transparent;
                    btn.Click += AddTable;
                    _tableStatus[i] = btn;
                }
            }
            pTable.Controls.Clear();
            for(int i = 1; i < 25; i++)
            {
                pTable.Controls.Add(_tableStatus[i]);
            }
        }
    }
}

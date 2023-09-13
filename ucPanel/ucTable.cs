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

        public Button[] _tableStatus = new Button[30];
        public ucTable()
        {
            InitializeComponent();
            for (int i = 1; i < 25; i++)
            {
                Button btn = new Button();
                btn.Text = "+";
                btn.Name = "btnEmpty" + i.ToString();
                btn.Dock = DockStyle.Fill;
                btn.BackColor = Color.Transparent;
                _tableStatus[i] = btn;
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }

        public void ShowTable(Button[] _tableStatus)
        {
            pTable.Controls.Clear();
            for (int i = 1; i < 25; i++)
            {
                if (_tableStatus[i].Name.Substring(0, 8) == "btnEmpty")
                {
                    Button btn = new Button();
                    btn.Text = " ";
                    btn.Name = "btnEmpty" + i.ToString();
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.Transparent;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    this._tableStatus[i] = btn;
                    pTable.Controls.Add(this._tableStatus[i]);
                }
                else
                {
                    Button btn = new Button();
                    btn.Text = _tableStatus[i].Text;
                    btn.Name = _tableStatus[i].Name;
                    btn.Dock = DockStyle.Fill;
                    btn.BackColor = Color.White;
                    btn.Click += Btn_Click;
                    this._tableStatus[i] = btn;
                    pTable.Controls.Add(this._tableStatus[i]);
                }
                
            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setting(sender, _tableStatus);
        }
    }
}

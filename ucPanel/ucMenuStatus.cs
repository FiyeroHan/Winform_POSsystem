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
    public partial class ucMenuStatus : UserControl
    {
        public event menulist removelist;
        public ucMenuStatus()
        {
            InitializeComponent();
        }

        public ucMenuStatus(int price, string name)
        {
            lblPrice.Text = price.ToString();
            lblMenu.Text = name;

        }

        public ucMenuStatus(int price, string name, string detail)
        {
            lblPrice.Text = price.ToString();
            lblMenu.Text = name;
            lblDetail.Text = detail;
        }
        #region Properties

        private string _menu;
        private string _detail;
        private int _price;

        [Category("Custom Props")]
        public string Menu 
        { 
            get { return _menu; }
            set { _menu = value; lblMenu.Text = value; }
        }

        [Category("Custom Props")]
        public string Detail 
        {
            get { return _detail; }
            set { _detail = value; lblDetail.Text = value; }
        }

        [Category("Custom Props")]
        public int Price 
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString(); }
        }

        #endregion

        private void btnCancle_Click(object sender, EventArgs e)
        {
            removelist(sender, this);
        }
    }
}

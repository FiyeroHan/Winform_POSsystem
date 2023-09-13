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
        public event floatDetail FloatDetail;

        public List<ucPanel.ucMenuStatus> table1 = new List<ucPanel.ucMenuStatus>();
        public List<ucPanel.ucMenuStatus> table2 = new List<ucPanel.ucMenuStatus>();
        public List<ucPanel.ucMenuStatus> table3 = new List<ucPanel.ucMenuStatus>();
        public List<ucPanel.ucMenuStatus> table4 = new List<ucPanel.ucMenuStatus>();
        public List<ucPanel.ucMenuStatus> table5 = new List<ucPanel.ucMenuStatus>();
        public List<ucPanel.ucMenuStatus> table6 = new List<ucPanel.ucMenuStatus>();
        public List<ucPanel.ucMenuStatus> table7 = new List<ucPanel.ucMenuStatus>();

        public int table1_payed_price = 0;
        public int table2_payed_price = 0;
        public int table3_payed_price = 0;
        public int table4_payed_price = 0;
        public int table5_payed_price = 0;
        public int table6_payed_price = 0;
        public int table7_payed_price = 0;
        public ucTable()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {

            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table1, table1_payed_price);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table2, table2_payed_price);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table3, table3_payed_price);
        }
        private void btnTable4_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table4, table4_payed_price);
        }
        private void btnTable5_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table5, table5_payed_price);
        }
        
        private void btnTable6_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table6, table6_payed_price);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            FloatDetail(sender, table7, table7_payed_price);
        }
    }
}

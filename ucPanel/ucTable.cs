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

        public ucTable()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {

            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            FloatDetail("Table1 Button", table1);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            FloatDetail("Table2 Button", table2);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            FloatDetail("Table3 Button", table3);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            FloatDetail("Table7 Button", table7);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            FloatDetail("Table6 Button", table6);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            FloatDetail("Table5 Button", table5);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            FloatDetail("Table4 Button", table4);
        }
    }
}

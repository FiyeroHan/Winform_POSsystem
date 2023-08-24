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
        public event delLogSender eLogSender;

        public ucTable()
        {
            InitializeComponent();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            eLogSender("Table1 Button");
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            eLogSender("Table2 Button");
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            eLogSender("Table3 Button");
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            eLogSender("Table7 Button");
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            eLogSender("Table6 Button");
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            eLogSender("Table5 Button");
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            eLogSender("Table4 Button");
        }
    }
}

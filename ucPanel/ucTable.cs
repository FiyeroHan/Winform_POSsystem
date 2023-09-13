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
        public ucTable()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {

            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }
        private void btnTable4_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }
        private void btnTable5_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }
        
        private void btnTable6_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            FloatDetail(sender);
        }
    }
}

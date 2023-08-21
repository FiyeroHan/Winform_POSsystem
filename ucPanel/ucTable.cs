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
    }
}

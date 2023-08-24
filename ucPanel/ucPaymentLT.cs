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
    public partial class ucPaymentLT : UserControl
    {
        public event floatPayment floatPayment;

        public ucPaymentLT()
        {
            InitializeComponent();
        }

        private void btnDutch_Click(object sender, EventArgs e)
        {
            floatPayment("dutch", "dutch");
        }

        private void btnDirectInput_Click(object sender, EventArgs e)
        {
            floatPayment("direct", "direct");
        }
    }
}

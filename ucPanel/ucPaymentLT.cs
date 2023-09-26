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

namespace Unicon1.ucPanel
{
    public partial class ucPaymentLT : UserControl
    {
        public event floatPayment floatPayment;
        public event backToMenu backToMenu;

        public ucPaymentLT()
        {
            InitializeComponent();
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Height = 2;
            lbl.Dock = DockStyle.Bottom;
            lbl.Name = "lbl1";
            lbl.BackColor = Color.Orange;
            panel1.Controls.Add(lbl);

        }

        private void UcPaymentLT_Load(object sender, EventArgs e)
        {
            btnDirectInput.ForeColor = Color.Orange;
            btnDutch.ForeColor = Color.DarkGray;
        }

        private void btnDutch_Click(object sender, EventArgs e)
        {
            btnDirectInput.ForeColor = Color.DarkGray;
            btnDutch.ForeColor = Color.Orange;
            floatPayment("dutch", "dutch");
        }

        private void btnDirectInput_Click(object sender, EventArgs e)
        {
            btnDirectInput.ForeColor = Color.Orange;
            btnDutch.ForeColor = Color.DarkGray;
            floatPayment("direct", "direct");
        }

    }
}

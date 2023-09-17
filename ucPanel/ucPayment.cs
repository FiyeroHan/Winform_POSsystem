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
    public partial class ucPayment : UserControl
    {
        public event passprice inputprice;

        public int total_price = 0;
        public int payed_price = 0;

        public ucPayment(int total_price, int payed_price)
        {
            InitializeComponent();
            this.total_price = total_price;
            this.payed_price = payed_price;
            lblPrice.Text = (this.total_price-this.payed_price).ToString();
        }

        private void UcPayment_Load(object sender, EventArgs e)
        {
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            tboxPrice.Text += "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            inputprice(sender, int.Parse(tboxPrice.Text == "" ? "0" : tboxPrice.Text));
            payed_price += int.Parse(tboxPrice.Text == "" ? "0" : tboxPrice.Text);
            tboxPrice.Text = "";
            
        }

    }
}

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
    public partial class ucPlaceStatus : UserControl
    {
        public string placeName = string.Empty;
        public string btnName = string.Empty;

        public ucPlaceStatus(string name, string btnName)
        {
            InitializeComponent();
            lblPlaceName.Text = name;
            placeName = name;
            this.btnName = btnName;
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            string input = tboxInput.Text;
            if(input != "")
            {
                lblPlaceName.Text = input;
                placeName = input;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

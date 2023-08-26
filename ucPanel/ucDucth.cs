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
    public partial class ucDucth : UserControl
    {
        int numPerson = 0;

        public event floatDutch floatdutch;
        public ucDucth()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numPerson = (int)numericUpDown1.Value;
            floatdutch("button1", numPerson);

        }
    }
}

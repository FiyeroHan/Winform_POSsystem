﻿using System;
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
    public partial class ucPayTypeLT : UserControl
    {
        public event backToMenu backToMenu;

        public ucPayTypeLT()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backToMenu(sender);
        }
    }
}

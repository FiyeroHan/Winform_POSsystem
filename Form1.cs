using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicon1.ucPanel;

namespace Unicon1
{
    public partial class Form1 : Form
    {
        ucPanel.ucTable ucTable = new ucPanel.ucTable();
        ucPanel.ucLogin ucLogin = new ucPanel.ucLogin();

        public Form1()
        {
            InitializeComponent();
        
        }

        private Form1(Form parent,double opacity)
        {
            FormBorderStyle = FormBorderStyle.None;

            //불투명 색상
            BackColor = Color.Black;

            //불투명 정도, 0에 가까울수록 투명
            Opacity = opacity;

            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Size = parent.ClientSize;
            Location = parent.PointToScreen(Point.Empty);

        }  

        public static DialogResult ShowDialog(Form parent, Form dialog, double opacity = 0.65)
        {
            var background = new Form1(parent, opacity);
            background.MdiParent = parent.MdiParent;
            background.Show();

            dialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = dialog.ShowDialog(background);
            background.Close();
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin.LoginSuccess += UcLogin_LoginSuccess;
            pMain.Controls.Add(ucLogin);
        }

        private void UcLogin_LoginSuccess(object sender)
        {
            pMain.Controls.Remove(ucLogin);
            ucTable.FloatDetail += fDetail;
            pMain.Controls.Add(ucTable);
        }

        private void fDetail(object oSender, List<ucPanel.ucMenuStatus> table)
        {
            ucPanel.ucDetail ucDetail = new ucPanel.ucDetail(table);
            ucDetail.BackToTable += fTable;

            pMain.Controls.Clear();
            pMain.Controls.Add(ucDetail);


        }

        private void fTable(object oSender, List<ucPanel.ucMenuStatus> table)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(ucTable);
        }

    }
}

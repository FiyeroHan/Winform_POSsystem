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
    public partial class ucLogin : UserControl
    {
        public event login LoginSuccess;
        string id = "user";
        string pw = "123";
        public ucLogin()
        {
            InitializeComponent();
        }

        private void cboxPWVisible_CheckedChanged(object sender, EventArgs e)
        {
            char pwchar = new char();
            if (!cboxPWVisible.Checked) pwchar = '*';
            tboxPW.PasswordChar = pwchar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tboxID.Text == id && tboxPW.Text == pw) LoginSuccess(sender);
            else if (tboxID.Text.Length == 0) MessageBox.Show("아이디를 입력해주세요.");
            else if (tboxPW.Text.Length == 0) MessageBox.Show("비밀번호를 입력해주세요");
            else if (tboxID.Text != id) MessageBox.Show("잘못된 아이디입니다.");
            else if (tboxPW.Text != pw) MessageBox.Show("잘못된 비밀번호입니다.");
        }
    }
}

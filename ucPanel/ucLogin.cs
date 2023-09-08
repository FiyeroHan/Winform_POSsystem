using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Unicon1.ucPanel
{
    public partial class ucLogin : UserControl
    {
        public event login LoginSuccess;

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
            string id = tboxID.Text;
            string pw = tboxPW.Text;
            string apiUrl = "http://hoshi-kirby.xyz/api/v1/user/login?id=" + id + "&pw=" + pw;
            try
            {
                WebRequest request = WebRequest.Create(apiUrl);
                string responseFromServer = string.Empty;
                request.Method = "GET";
                request.ContentType = "application/json";
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                    responseFromServer = reader.ReadToEnd();
                JObject jobect = JObject.Parse(responseFromServer);
                JToken jtoken = jobect["data"];
                if (jtoken["access_token"] == null) MessageBox.Show(jtoken["message"].ToString());
                else LoginSuccess(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnLogin_Click(sender, e);
        }
    }
}

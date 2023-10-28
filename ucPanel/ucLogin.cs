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
using System.Web.Script.Serialization;

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
            string apiUrl = Properties.Settings.Default.url + "biz/user/";
            string result = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.ContentType = "application/json;charset=utf-8";
            request.Method = "POST";
            try
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(new User(id, pw));
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    Console.WriteLine(result.ToString());
                }
                JObject jobject = JObject.Parse(result);
                JToken jtoken = jobject["status"];
                if (jtoken == null || jtoken.ToString() != "200") throw new Exception();
                Properties.Settings.Default.access_token = jobject["access_token"].ToString();
                Properties.Settings.Default.refresh_token = jobject["refresh_token"].ToString();
                LoginSuccess(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        class User
        {
            public string email { get; set; }
            public string password { get; set; }
            public User(string email, string password)
            {
                this.email = email;
                this.password = password;
            }
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnLogin_Click(sender, e);
        }

    }
}

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicon1.ucPanel
{
    public partial class ucCategory : UserControl
    {
        public event floatmenu FloatMenu;
        Dictionary<string, List<menu_info>> menu = new Dictionary<string, List<menu_info>>();
        List<string> categoryList = new List<string>();
        public ucCategory()
        {
            InitializeComponent();
            string apiUrl = Properties.Settings.Default.url + "api/biz/store/my/category";
            string result = string.Empty;
            string access_token = Properties.Settings.Default.access_token;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.ContentType = "application/json;charset=utf-8";
            request.Method = "GET";
            request.Headers.Add("Authorization","Bearer "+ access_token);
            try
            {

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    Console.WriteLine(result.ToString());
                }
                JObject jobject = JObject.Parse(result);
                JToken jtoken = jobject["status"];
                if (jtoken == null || jtoken.ToString() != "200") throw new Exception();
                foreach(JToken token in jobject["categories"])
                {
                    Console.WriteLine(token["id"].ToString()+" " + token["name"].ToString());
                    Button btn = new Button();
                    btn.BackColor = Color.Transparent;
                    btn.Dock = DockStyle.Fill;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                    btn.ForeColor = Color.Gray;
                    btn.Margin = new Padding(0);
                    btn.Name = "btnCategory" + token["id"];
                    menu[token["id"].ToString()] = menu_Infos(token["id"].ToString());
                    btn.Text = token["name"].ToString();
                    categoryList.Add(token["name"].ToString());
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += Btn_Click;
                    tableLayoutPanel3.Controls.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<menu_info> menu_Infos(string cateId)
        {
            List<menu_info> res = new List<menu_info>();
            string apiUrl = Properties.Settings.Default.url + "api/biz/store/my/stock?category_id=" + cateId;
            string result = string.Empty;
            string access_token = Properties.Settings.Default.access_token;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.ContentType = "application/json;charset=utf-8";
            request.Method = "GET";
            request.Headers.Add("Authorization", "Bearer " + access_token);
            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    Console.WriteLine(result.ToString());
                }
                JObject jobject = JObject.Parse(result);
                JToken jtoken = jobject["status"];
                if (jtoken == null || jtoken.ToString() != "200") throw new Exception();
                foreach (JToken token in jobject["stocks"])
                {
                    menu_info m = new menu_info();
                    m.price = int.Parse(token["price"].ToString());
                    m.describe = token["describe"].ToString();
                    m.name = token["name"].ToString();
                    res.Add(m);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (Button b in tableLayoutPanel3.Controls) b.ForeColor = Color.Gray;
            Button btn = sender as Button;
            btn.ForeColor = Color.Orange;
            FloatMenu(sender, menu[btn.Name.Substring(11)]);
        }
    }
}

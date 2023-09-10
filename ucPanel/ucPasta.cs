using Newtonsoft.Json.Linq;
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
    public partial class ucPasta : UserControl
    {
        public struct menu
        {
            public string name;
            public double price;
        }

        public event menulist addlist;
        string _storecode = string.Empty;
        List<menu> list = new List<menu>();


        public ucPasta(string storecode)
        {
            InitializeComponent();
            _storecode = storecode;

            string apiUrl = "http://hoshi-kirby.xyz/api/v1/stocks/list?store_code="+storecode;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                string responseFromServer = string.Empty;
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.PreAuthenticate = true;
                //request.Headers.Add("Authorization", "Bearer " + _token);
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                    responseFromServer = reader.ReadToEnd();
                JObject jobect = JObject.Parse(responseFromServer);
                JToken jtoken = jobect["stocks"];
                foreach (JToken token in jtoken)
                {
                    menu menu = new menu();
                    menu.name = token["stock_name"].ToString();
                    menu.price = double.Parse(token["stock_price"].ToString());
                    list.Add(menu);
                }
                //textBoxResult.Text += jtoken.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for(int i = 0; i < list.Count; i++)
            {
                Button btn = new Button();
                btn.Name = "btnMenu" + i.ToString();
                btn.Text = list[i].name.ToString() + "\r\n\r\n" + list[i].price.ToString();
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                btn.Dock = System.Windows.Forms.DockStyle.Fill;
                btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                btn.Location = new System.Drawing.Point(405, 20);
                btn.Margin = new System.Windows.Forms.Padding(10);
                btn.Size = new System.Drawing.Size(300, 200);
                btn.TabIndex = i;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.UseVisualStyleBackColor = false;
                btn.Click += Btn_Click;

                tableLayoutPanel4.Controls.Add(btn);

                
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ucMenuStatus menuInfo = new ucMenuStatus();
            menuInfo.Menu = btn.Text.Split('\r')[0];
            menuInfo.Detail = "";
            menuInfo.Price = int.Parse(btn.Text.Split('\r')[2]);


            addlist(sender, menuInfo);
        }
    }
}

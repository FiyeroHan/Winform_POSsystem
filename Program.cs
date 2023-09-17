using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;


namespace Unicon1
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //TimerCallback callback = state => SendHttpRequest();

            // 1초마다 콜백 메서드 실행
            //System.Threading.Timer timer = new System.Threading.Timer(callback, null, 0, 1000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }

        static async void SendHttpRequest()
        {
            // HTTP 요청을 보낼 URL 설정
            string apiOrderListUrl = "http://hoshi-kirby.xyz/api/v1/order/list";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiOrderListUrl);
                string responseFromServer = string.Empty;
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.PreAuthenticate = true;
                request.Headers.Add("Authorization", "Bearer " + Form1._token);
                using (WebResponse response = await request.GetResponseAsync())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                    responseFromServer = await reader.ReadToEndAsync();
                JObject jobect = JObject.Parse(responseFromServer);
                JToken jtoken = jobect["stores"];
                Console.WriteLine($"서버 응답 성공 - {DateTime.Now}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{

            //    // HttpClient 생성
            //    using (HttpClient httpClient = new HttpClient())
            //    {
            //        // 서버에 GET 요청 보내고 응답 받기 (비동기로 처리)
            //        HttpResponseMessage response = await httpClient.GetAsync(apiOrderListUrl);

            //        // 응답 확인
            //        if (response.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine($"서버 응답 성공 - {DateTime.Now}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"서버 응답 실패 - {DateTime.Now}");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"오류 발생: {ex.Message}");
            //}

        }



    }
}

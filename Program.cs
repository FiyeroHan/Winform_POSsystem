using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;


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
            TimerCallback callback = state => SendHttpRequest();

            // 1초마다 콜백 메서드 실행
            System.Threading.Timer timer = new System.Threading.Timer(callback, null, 0, 1000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }

        static async void SendHttpRequest()
        {
            try
            {
                // HTTP 요청을 보낼 URL 설정
                string url = "http://hoshi-kirby.xyz/api/v1/order/list";

                // HttpClient 생성
                using (HttpClient httpClient = new HttpClient())
                {
                    // 서버에 GET 요청 보내고 응답 받기 (비동기로 처리)
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // 응답 확인
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"서버 응답 성공 - {DateTime.Now}");
                    }
                    else
                    {
                        Console.WriteLine($"서버 응답 실패 - {DateTime.Now}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류 발생: {ex.Message}");
            }
        }



    }
}

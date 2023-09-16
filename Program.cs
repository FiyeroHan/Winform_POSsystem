using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


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
            //Thread myThread = new Thread(Func);
            //myThread.Start(7);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i + 1);
            //    Thread.Sleep(100);
            //}


            //Console.WriteLine("메인쓰레드 종료");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }

        private static void Func(object obj)
        {
            int num = (int)obj;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
        }



    }
}

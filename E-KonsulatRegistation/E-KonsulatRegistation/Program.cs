using mevoronin.RuCaptchaNETClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_KonsulatRegistation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Thread thread = new Thread(Method);
            //thread.Start();
            //Thread thread2 = new Thread(Method);
            //thread2.Start();
            //Thread thread3 = new Thread(Method);
            //thread3.Start();
            //Thread thread5 = new Thread(Method);
            //thread5.Start();
            //Thread thread4 = new Thread(Method);
            //thread4.Start();


            const string API_KEY = "1281f43cd9caa77cf65ff89fc95d6961";
            RuCaptchaClient client = new RuCaptchaClient(API_KEY);
            string captcha_id = client.UploadCaptchaFile(@"C:\Kahovsky\Pictures\XAzTmeRYtAo.jpg");
            string answer = null;
            while (string.IsNullOrEmpty(answer))
            {
                Thread.Sleep(2500);
                try
                {
                    answer = client.GetCaptcha(captcha_id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public static void Method()
        {
            const string API_KEY = "1281f43cd9caa77cf65ff89fc95d6961";
            RuCaptchaClient client = new RuCaptchaClient(API_KEY);
            string captcha_id = client.UploadCaptchaFile(@"C:\Kahovsky\Pictures\XAzTmeRYtAo.jpg");
            string answer = null;
            while (string.IsNullOrEmpty(answer))
            {
                Thread.Sleep(1000);
                try
                {
                    answer = client.GetCaptcha(captcha_id);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

    }
}

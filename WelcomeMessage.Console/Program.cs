using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace WelcomeMessage.Console
{
    class Program
    {
        const string WelcomeMessageUrl = "WelcomeMessageUrl";
        const string DefaultWelcomeMessageUrl = "http://localhost:55269/api/WelcomeMessage";

        static void Main(string[] args)
        {
            using (var client = new WebClient()) 
            {
                client.Headers.Add("Content-Type:application/json");  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString(GetWelcomeMessageUrl());

                System.Console.WriteLine(result);

                System.Console.ReadKey();
                
            }  
        }


        private static string GetWelcomeMessageUrl()
        {
            var url = ConfigurationManager.AppSettings[WelcomeMessageUrl];
            return string.IsNullOrEmpty(url) ? DefaultWelcomeMessageUrl : url;
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace consoleapi
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json;charset=utf-8");//Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://210.59.250.98/moeaidbAPI/v1/Company/Company?$top=1&$format=JSON"); //URI
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }

    }
}

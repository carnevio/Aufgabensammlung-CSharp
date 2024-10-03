using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace _17_Witze_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true) 
            {
                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                request.Method = "GET";

                
                request.ContentType = "application/json; charset=utf-8";
                WebResponse response = request.GetResponse();
               
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string json = reader.ReadToEnd();


                dynamic data = JsonConvert.DeserializeObject(json);
                Console.WriteLine(data[0]["text"]);

                Console.Write("Nächster Witz holen? j/n");
                string joke = Console.ReadLine();

                if (joke == "j") 
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
                Console.WriteLine("Schade:(");
            }

        }
    }
}

using System;
using System.IO;
using System.Net;

namespace BPT.Test.CETM.FrontEnd.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetItems();
        }
        private static void GetItems()
        {
            var url = $"http://localhost:44378/weatherforecast";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }
    }
}

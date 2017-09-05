using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Line_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.line.me/v2/bot/message/push");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization", "Bearer Token .....");
            httpWebRequest.Method = "POST";

            //將測試訊息預先寫死
            var json = Encoding.UTF8.GetBytes("{\"to\":\"User ID ...\",\"messages\":[{\"type\":\"text\",\"text\":\"Hello World\"}]}");

            Stream stream = httpWebRequest.GetRequestStream();
            stream.Write(json, 0, json.Length);
            stream.Close();

            WebResponse response = httpWebRequest.GetResponse();
        }
    }
}

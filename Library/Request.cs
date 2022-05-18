using System.Net;

namespace Library
{
    public class Request
    {
        public static string GetData(string? ip)
        {
            WebRequest requestGet = WebRequest.Create($"http://ip-api.com/json/{ip}?fields=query,status,message,continent,country,regionName,city");
            WebResponse response = requestGet.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
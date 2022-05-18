using IPLocation;
using System.Text.Json;

namespace Library
{
    public class IpApiClient
    {
        public async Task<Data> GetData(string? ip)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"http://ip-api.com/json/{ip}?fields=query,status,message,continent,country,regionName,city");
            string strData = await response.Content.ReadAsStringAsync();
            Data? data = JsonSerializer.Deserialize<Data>(strData);
            return data;
        }
    }
}
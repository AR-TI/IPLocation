namespace Library
{
    public class Request
    {
        public async Task<string> GetData(string? ip)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"http://ip-api.com/json/{ip}?fields=query,status,message,continent,country,regionName,city");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
using IPLocation;
using Library;
using System.Text.Json;

Console.Write("Input IP: ");

string? ip = Console.ReadLine();
Request request = new Request();
string? result = await request.GetData(ip);
Data? data = JsonSerializer.Deserialize<Data>(result);
if (data?.Status == "fail")
{
    Console.WriteLine(data?.Message);
}
else
{
    Print(data);
}

static void Print(Data? data)
{
    Console.WriteLine("IP: " + data?.IP);
    Console.WriteLine("Continent: " + data?.Continent);
    Console.WriteLine("Country: " + data?.Country);
    Console.WriteLine("Region: " + data?.Region);
    Console.WriteLine("City: " + data?.City);
}

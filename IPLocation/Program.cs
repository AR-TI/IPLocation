using IPLocation;
using Library;

Console.Write("Input IP: ");

string? ip = Console.ReadLine();
IpApiClient request = new IpApiClient();
Data? data = await request.GetData(ip);
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

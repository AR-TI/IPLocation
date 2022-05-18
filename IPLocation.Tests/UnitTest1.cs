using Library;

namespace IPLocation.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("qwerty", ExpectedResult = "{\"status\":\"fail\",\"message\":\"invalid query\",\"query\":\"qwerty\"}")]
        [TestCase("37.212.90.44", ExpectedResult = "{\"status\":\"success\",\"continent\":\"Europe\",\"country\":\"Belarus\",\"regionName\":\"Grodnenskaya\",\"city\":\"Hrodna\",\"query\":\"37.212.90.44\"}")]
        public string Test1(string ip)
        {
            Request request = new Request();
            return request.GetData(ip);
        }
    }
}
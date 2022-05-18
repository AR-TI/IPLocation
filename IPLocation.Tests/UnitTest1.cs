using Library;

namespace IPLocation.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("qwerty", ExpectedResult = new Data() { Status= "fail", Message= "invalid query", IP= "qwerty" })]
        [TestCase("37.212.90.44", ExpectedResult = "{\"status\":\"success\",\"continent\":\"Europe\",\"country\":\"Belarus\",\"regionName\":\"Grodnenskaya\",\"city\":\"Hrodna\",\"query\":\"37.212.90.44\"}")]
        public string Test1(string ip)
        {
            IpApiClient request = new IpApiClient();
            return request.GetData(ip);
        }
    }
}
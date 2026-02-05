using NUnit.Framework;
using ReqresApiAutomation.Clients;

namespace ReqresApiAutomation.Base
{
    public class TestBase
    {
        protected static ReqresClient client;
        [SetUp]
        public void GlobalSetup()
        {
            client = new ReqresClient();
        }
    }
}
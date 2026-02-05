using NUnit.Framework;
using System.Net;
using ReqresApiAutomation.Base;

namespace ReqresApiAutomation.Tests
{
    public class GetUserTests : TestBase
    {
        [Test]
        public void GetUser_ShouldReturn200_AndValidBody()
        {
            var response = client.GetUser(2);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Does.Contain("email"));
            Assert.That(response.ContentType, Does.Contain("application/json"));
            Assert.That(response.ResponseStatus, Is.EqualTo(RestSharp.ResponseStatus.Completed));
        }
    }
}

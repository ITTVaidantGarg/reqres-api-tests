

using NUnit.Framework;
using System.Net;
using ReqresApiAutomation.Base;

namespace ReqresApiAutomation.Tests
{
    public class PutUserTests : TestBase
    {
        [Test]
        public void UpdateUser_ShouldReturn200()
        {
            var body = new { name = "Vaidant Garg", job = "Senior QA" };
            var response = client.UpdateUser(2, body);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Does.Contain("Senior QA"));
        }
    }
}

using NUnit.Framework;
using System.Net;
using ReqresApiAutomation.Base;

namespace ReqresApiAutomation.Tests
{
    public class PatchUserTests : TestBase
    {
        [Test]
        public void PatchUser_ShouldReturn200()
        {
            var body = new { job = "Lead QA" };
            var response = client.PatchUser(2, body);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Does.Contain("Lead QA"));
        }
    }
}
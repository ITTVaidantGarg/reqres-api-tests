using NUnit.Framework;
using System.Net;
using ReqresApiAutomation.Base;
using ReqresApiAutomation.Models;

namespace ReqresApiAutomation.Tests
{
    public class PostUserTests : TestBase
    {
        [Test]
        public void CreateUser_ShouldReturn201()
        {
            var body = new CreateUserBody
            {
                name = "Vaidant",
                job = "QA Engineer"
            };

            var response = client.PostUser(body);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            Assert.That(response.Content, Does.Contain("Vaidant"));
            Assert.That(response.Content, Does.Contain("QA Engineer"));
        }
    }
}

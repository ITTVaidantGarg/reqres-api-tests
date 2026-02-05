using NUnit.Framework;
using System.Net;
using ReqresApiAutomation.Base;

namespace ReqresApiAutomation.Tests
{
    [TestFixture]
    public class DeleteUserTests : TestBase
    {
        [Test]
        public void DeleteUser_ShouldReturn204()
        {
            var response = client.DeleteUser(2);
            Assert.Multiple(() =>
            {
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent),
                    "The API should return status 204 (No Content).");

                Assert.That(string.IsNullOrEmpty(response.Content), Is.True,
                    "The response body should be empty for a 204 status.");
            });
        }
    }
}
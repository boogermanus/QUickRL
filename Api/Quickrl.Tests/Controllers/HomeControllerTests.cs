using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using QuickrlApi.Controllers;

namespace Quickrl.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _controller;
        
        [SetUp]
        public void SetUp()
        {
            _controller = new HomeController();
        }

        [TearDown]
        public void TearDown()
        {
            _controller = null;
        }
        
        [Test]
        public void GetReturnsOkObjectResult()
        {

            Assert.That(() => _controller.Get(), Is.TypeOf<OkObjectResult>());
        }

        [Test]
        public void GetReturnsOkObjectResultWithNonNullMessage()
        {
            var result = _controller.Get();
            var okObjectResult = (OkObjectResult)result;

            Assert.That(okObjectResult.Value, Is.EqualTo("QUickRL API"));
        }
    }
}
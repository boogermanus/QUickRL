using FakeItEasy;
using NUnit.Framework;
using Quickrl.Core.ApiModels;
using Quickrl.Core.Interfaces;
using Quickrl.Core.Models;
using Quickrl.Core.Services;

namespace Quickrl.Tests.Services
{
    [TestFixture]
    public class ShortUrlServiceTests
    {
        private IShortUrlService _service;
        private IShortUrlRepository _repository;
        
        [SetUp]
        public void SetUp()
        {
            _repository = A.Fake<IShortUrlRepository>();
            _service = new ShortUrlService(_repository);
        }

        [TearDown]
        public void TearDown()
        {
            _repository = null;
            _service = null;
        }

        [Test]
        public void AddShortUrlShouldCallRepositoryAdd()
        {
            _service.AddShortUrl(new ShortUrlModel { RedirectUrl = "https://test.com" });
            A.CallTo(() => _repository.Add(A<ShortUrl>.Ignored)).MustHaveHappened();
        }
    }
}
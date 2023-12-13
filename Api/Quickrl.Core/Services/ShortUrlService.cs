using System;
using System.Threading.Tasks;
using Quickrl.Core.ApiModels;
using Quickrl.Core.Interfaces;
using Quickrl.Core.Models;

namespace Quickrl.Core.Services
{
    public class ShortUrlService : IShortUrlService
    {
        private readonly IShortUrlRepository _shortUrlRepository;
        
        public ShortUrlService(IShortUrlRepository shortUrlRepository)
        {
            _shortUrlRepository = shortUrlRepository;
        }

        public async Task<ShortUrlModel> AddShortUrl(ShortUrlModel model)
        {
            var domainModel = model.ToDomainModel();
            domainModel.CreateDate = DateTime.Now;
            domainModel.HitCount = 0;
            domainModel.UserId = Guid.NewGuid().ToString(); // Need to give this the ability to get users
            domainModel.ShortUrlId = "test2"; // need to generate short URL

            var newModel = await _shortUrlRepository.Add(domainModel);

            return newModel.ToApiModel();
        }
    }
}
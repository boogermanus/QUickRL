using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quickrl.Core.ApiModels;
using Quickrl.Core.Interfaces;
using Quickrl.Core.Models;

namespace QuickrlApi.Controllers
{
    [ApiController]
    [Route("api/shortutl")]
    public class ShortUrlController
    {
        private readonly IShortUrlService _shortUrlService;

        public ShortUrlController(IShortUrlService shortUrlService)
        {
            _shortUrlService = shortUrlService;
        }

        [Route("api/shorturl/add")]
        [HttpPost]
        public async Task<ShortUrlModel> Add([FromBody] ShortUrlModel model)
        {
            var result = await _shortUrlService.AddShortUrl(model);

            return result;
        }
    }
}
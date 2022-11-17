using System.Threading.Tasks;
using Quickrl.Core.ApiModels;
using Quickrl.Core.Models;

namespace Quickrl.Core.Interfaces
{
    public interface IShortUrlService
    {
        Task<ShortUrlModel> AddShortUrl(ShortUrlModel model);
    }
}
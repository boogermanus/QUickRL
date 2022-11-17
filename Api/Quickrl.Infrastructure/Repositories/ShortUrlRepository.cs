using Quickrl.Core.Interfaces;
using Quickrl.Core.Models;

namespace Quickrl.Infrastructure.Repositories
{
    public class ShortUrlRepository : BaseRepository<ShortUrl>, IShortUrlRepository
    {
        public ShortUrlRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
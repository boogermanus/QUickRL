using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quickrl.Core.Models;

namespace Quickrl.Infrastructure
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<ShortUrl> ShortUrls { get; set; }
        
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
using Microsoft.EntityFrameworkCore;
using AvatarApi.Models;

namespace AvatarApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
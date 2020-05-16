using BotAppData.Models;
using BotAppData.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BotAppData
{
    public class BotAppContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public BotAppContext(DbContextOptions<BotAppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfigurations());
        }
    }
}

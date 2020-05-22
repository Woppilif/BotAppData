using BotAppData.Models;
using BotAppData.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BotAppData
{
    public class BotAppContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Group> BroadcastGroup { get; set; }
        public DbSet<Broadcast> Broadcast { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public BotAppContext(DbContextOptions<BotAppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new BroadcastConfigurations());
            //modelBuilder.ApplyConfiguration(new BroadcastGroupConfigurations());

            //modelBuilder.ApplyConfiguration(new UsersConfigurations());
            base.OnModelCreating(modelBuilder);
        }
    }
}

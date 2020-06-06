using BotAppData.Models;
using BotAppData.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BotAppData
{
    public class BotAppContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Group> BroadcastGroup { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<PatternMessage> PatternMessages { get; set; }
        public DbSet<LinkSpyer> LinkSpyers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Payments> Payment { get; set; }
        public DbSet<ProductItems> ProductItem { get; set; }
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

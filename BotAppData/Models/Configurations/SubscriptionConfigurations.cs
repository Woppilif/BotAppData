using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class SubscriptionConfigurations : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Users).IsRequired();
            builder.Property(prop => prop.Begin).IsRequired();
            builder.Property(prop => prop.Product).IsRequired();
            builder.Property(prop => prop.IsActive).IsRequired();
        }
    }
}

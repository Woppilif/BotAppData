using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class PaymentsConfigurations : IEntityTypeConfiguration<Payments>
    {
        public void Configure(EntityTypeBuilder<Payments> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.ChatId).IsRequired();
            builder.Property(prop => prop.CreatedAt).IsRequired();
            builder.Property(prop => prop.CapturedAt).IsRequired();
            builder.Property(prop => prop.IsPayed).IsRequired();
            builder.Property(prop => prop.SubscriptionId).IsRequired();
            builder.Property(prop => prop.Amount).IsRequired();
            builder.Property(prop => prop.PaymentId).IsRequired();
            builder.Property(prop => prop.IsExtends).IsRequired();
        }
    }
}

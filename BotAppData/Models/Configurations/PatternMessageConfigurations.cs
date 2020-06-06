using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class PatternMessageConfigurations : IEntityTypeConfiguration<PatternMessage>
    {
        public void Configure(EntityTypeBuilder<PatternMessage> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Pattern).IsRequired();
            builder.Property(prop => prop.IsFirst).IsRequired();
            builder.Property(prop => prop.Message).IsRequired();
            builder.Property(prop => prop.Status).IsRequired();
        }
    }
}

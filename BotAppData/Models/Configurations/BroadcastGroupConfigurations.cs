using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class BroadcastGroupConfigurations : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired();
            builder.Property(prop => prop.Age).IsRequired();
            builder.Property(prop => prop.Type).IsRequired();
            builder.Property(prop => prop.Creator).IsRequired();
        }
    }
}

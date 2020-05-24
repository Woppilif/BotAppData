using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class UsersConfigurations : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.ChatId).IsRequired();
            builder.Property(prop => prop.CreatedAt).HasColumnType("TIMESTAMP(0)").IsRequired();
            builder.Property(prop => prop.Group).IsRequired();
            builder.Property(prop => prop.Platform).IsRequired();
        }
    }
}

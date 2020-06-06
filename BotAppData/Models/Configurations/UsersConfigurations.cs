using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class UsersConfigurations : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.Property(prop => prop.Id).IsRequired();
            builder.HasKey(prop => prop.ChatId);
            builder.Property(prop => prop.CreatedAt).HasColumnType("TIMESTAMP(0)").IsRequired();
            builder.Property(prop => prop.Group).IsRequired();
            builder.Property(prop => prop.Platform).IsRequired();
            builder.Property(prop => prop.Firstname).IsRequired();
            builder.Property(prop => prop.Lastname).IsRequired();
            builder.Property(prop => prop.Phone).IsRequired();
            builder.Property(prop => prop.Registered).IsRequired();
            builder.Property(prop => prop.Age).IsRequired();
            builder.Property(prop => prop.IsAdmin).IsRequired();
            builder.Property(prop => prop.IsTeacher).IsRequired();
        }
    }
}

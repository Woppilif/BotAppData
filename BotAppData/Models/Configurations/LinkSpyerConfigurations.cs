using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models.Configurations
{
    class LinkSpyerConfigurations : IEntityTypeConfiguration<LinkSpyer>
    {
        public void Configure(EntityTypeBuilder<LinkSpyer> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Lesson).IsRequired();
            builder.Property(prop => prop.CreatedAt).IsRequired();
            builder.Property(prop => prop.Users).IsRequired();
        }
    }
}

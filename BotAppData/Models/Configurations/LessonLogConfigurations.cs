using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models.Configurations
{
    class LessonLogConfigurations : IEntityTypeConfiguration<LessonLog>
    {
        public void Configure(EntityTypeBuilder<LessonLog> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.LessonId).IsRequired();
            builder.Property(prop => prop.CreatedAt).IsRequired();
            builder.Property(prop => prop.ChatId).IsRequired();
        }
    }
}

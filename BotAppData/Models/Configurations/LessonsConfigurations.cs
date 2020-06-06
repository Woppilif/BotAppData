using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BotAppData.Models.Configurations
{
    class LessonsConfigurations : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.LessonAt).HasColumnType("TIMESTAMP(0)").IsRequired();
            builder.Property(prop => prop.Group).IsRequired();
            builder.Property(prop => prop.Status).IsRequired();
            builder.Property(prop => prop.Pattern).IsRequired();
            builder.Property(prop => prop.Url).IsRequired();
            builder.Property(prop => prop.IsRepeats).IsRequired();
        }
    }
}

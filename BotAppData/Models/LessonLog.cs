using BotAppData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class LessonLog : IhaveId, IHaveChatId
    {
        public Guid Id { get; set; }
        public Guid LessonId { get; set; }
        public long ChatId { get; set; }
        public DateTime CreatedAt { get; set; }

        public LessonLog()
        {
            Id = new Guid();
            CreatedAt = DateTime.Now;
        }
    }
}

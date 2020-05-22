using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public Guid Group { get; set; }
        public DateTime LessonAt { get; set; }
        public bool Status { get; set; }

        public Lesson()
        {
            Id = new Guid();
        }
    }
}

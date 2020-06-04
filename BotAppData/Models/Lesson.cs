using System;

namespace BotAppData.Models
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public Guid Group { get; set; }
        public DateTime LessonAt { get; set; }
        public bool Status { get; set; }
        public string Url { get; set; }
        public Guid PatternId { get; set; }
        public bool IsRepeats { get; set; }

        public Lesson()
        {
            Id = new Guid();
        }
    }
}

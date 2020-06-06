using System;

namespace BotAppData.Models
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public Group Group { get; set; }
        public DateTime LessonAt { get; set; }
        public bool Status { get; set; }
        public string Url { get; set; }
        public Pattern Pattern { get; set; }
        public bool IsRepeats { get; set; }
        public Lesson()
        {
            Id = new Guid();
            Pattern = null;
            IsRepeats = false;
            Status = false;
            LessonAt = DateTime.Now.AddDays(1);
        }
    }
}

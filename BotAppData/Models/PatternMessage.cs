using System;

namespace BotAppData.Models
{
    public class PatternMessage
    {
        public Guid Id { get; set; }
        public Pattern Pattern { get; set; }
        public bool IsFirst { get; set; }
        public string Message { get; set; }
        public DateTime AtTime { get; set; }
        public bool Status { get; set; }

        public PatternMessage()
        {
            Id = new Guid();
            AtTime = DateTime.Now;
            IsFirst = false;
        }

        public string MakeMessage(string url,DateTime dateTime)
        {
            return Message.Replace("<url>", url)
                .Replace("<datetime>", $"{dateTime.Date.ToString().Split(' ')[0]} в {dateTime.Hour}:{dateTime.Minute}");
        }

    }
}

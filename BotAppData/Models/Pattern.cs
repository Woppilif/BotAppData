using System;

namespace BotAppData.Models
{
    public class Pattern
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Pattern()
        {
            Id = new Guid();
            Name = $"Паттерн {DateTime.Now}";
        }
    }
}

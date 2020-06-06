using BotAppData.Interfaces;
using System;

namespace BotAppData.Models
{
    public enum Products
    {
        Maraphone = 0,
        Lessons = 1,
        Trial = 1,
    }

    public class Subscription
    {
        public Guid Id { get; set; }
        public Users Users { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public Products Product { get; set; }
        public bool IsActive { get; set; }
        public Subscription()
        {
            Id = new Guid();
        }
    }
}

using System;
using BotAppData.Interfaces;

namespace BotAppData.Models
{
    public class Users : IUser
    {
        public Guid Id { get; set; }
        public long ChatId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Group { get; set; }
        public int Platform { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public bool Registered { get; set; }
        public Ages Age { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsTeacher { get; set; }

        public Users()
        {
            Id = new Guid();
            CreatedAt = DateTime.Now;
            Group = Guid.Empty;
        }

    }
}

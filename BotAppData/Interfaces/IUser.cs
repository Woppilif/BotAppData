using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Interfaces
{
    public enum Ages
    {
        Children = 1,
        Teens = 2,
        Students = 3,
        Adults = 4,
        Any = 5
    }
    public interface IUser
    {
        Guid Id { get; set; }
        long ChatId { get; set; }
        DateTime CreatedAt { get; set; }
        Guid Group { get; set; }
        int Platform { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Phone { get; set; }
        bool Registered { get; set; }
        Ages Age { get; set; }
        bool IsAdmin { get; set; }
        bool IsTeacher { get; set; }
    }
}

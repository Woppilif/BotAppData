﻿using System;

namespace BotAppData.Models
{
    public class Users
    {
        public Guid Id { get; private set; }
        public long ChatId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Users()
        {
            Id = new Guid();
            CreatedAt = DateTime.Now;
        }

    }
}

using BotAppData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class LinkSpyer
    {
        public Guid Id { get; set; }
        public virtual Lesson Lesson { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Users Users { get; set; }
        public LinkSpyer()
        {
            Id = new Guid();
            CreatedAt = DateTime.Now;
            Users = null;
        }
    }
}

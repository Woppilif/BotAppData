using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class Broadcast
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime MessageAt { get; set; }
        public BroadcastGroup Group { get; set; }

        public Broadcast()
        {
            Id = new Guid();
        }

    }
}

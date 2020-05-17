using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class BroadcastGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Type { get; set; }
        public Guid Creator { get; set; }

        public BroadcastGroup()
        {
            Id = new Guid();
        }
    }
}

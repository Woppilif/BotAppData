using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Type { get; set; }
        public Guid Creator { get; set; }
        public int StudentsCount { get; set; }
        public Group()
        {
            //Id = new Guid();
            //Age = 1;
            //Type = 1;
            //StudentsCount = 0;
        }
    }
}

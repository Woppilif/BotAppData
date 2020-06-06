using BotAppData.Interfaces;
using System;

namespace BotAppData.Models
{
    public class ProductItems
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Ages[] Ages { get; set; }

        public ProductItems()
        {
            Id = new Guid();
        }
    }
}
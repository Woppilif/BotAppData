using BotAppData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class Payments
    {
        public Guid Id { get; set; }
        public Users Users { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CapturedAt { get; set; }
        public bool IsPayed { get; set; }
        public Subscription Subscription { get; set; }
        public decimal Amount { get; set; }
        public string PaymentId { get; set; }
        public bool IsExtends { get; set; }
        public Payments()
        {
            Id = new Guid();
            CreatedAt = DateTime.Now;
            IsPayed = false;
            IsExtends = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models
{
    public class Payments
    {
        public Guid Id { get; set; }
        public long ChatId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CapturedAt { get; set; }
        public bool IsPayed { get; set; }
        public Guid SubscriptionId { get; set; }
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

using System;
using Domain.Common;

namespace Domain.Entities
{
    public class OrderItem : AuditableEntity
    {
        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid EventId { get; set; }
        public string TicketOwnerName { get; set; } = string.Empty;
        public string TicketOwnerEmail { get; set; } = string.Empty;
        public string TicketOwnerDocument { get; set; } = string.Empty;
        public bool isTicketCollected { get; set; } = false;
        public DateTime? TicketCollectedAt { get; set; }
        public Order Order { get; set; } = default!;
        public Event Event { get; set; } = default!;
    }
}

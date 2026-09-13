using SupportHub.Domain.Enums;

namespace SupportHub.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public TicketStatus Status { get; set; } = TicketStatus.Open;
        public TicketPriority Priority { get; set; } = TicketPriority.Medium;
        public int? AssignedAgentId { get; set; }
    }
}

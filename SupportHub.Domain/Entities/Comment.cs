namespace SupportHub.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public bool IsInternal { get; set; } = false;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public Ticket Ticket { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}

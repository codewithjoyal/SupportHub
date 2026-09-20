namespace SupportHub.Domain.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int? AssignedByUserId { get; set; }
        public User User { get; set; } = null!;
        public Role Role { get; set; } = null!;
        public User? AssignedByUser { get; set; }
    }
}
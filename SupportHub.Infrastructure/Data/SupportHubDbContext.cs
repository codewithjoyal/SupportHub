using Microsoft.EntityFrameworkCore;
using SupportHub.Domain.Entities;

namespace SupportHub.Infrastructure.Data
{
    public class SupportHubDbContext:DbContext
    {
        public SupportHubDbContext(DbContextOptions<SupportHubDbContext> options):base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(SupportHubDbContext).Assembly);
        }
    }
}

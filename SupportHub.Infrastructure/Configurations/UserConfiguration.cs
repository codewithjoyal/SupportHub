using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupportHub.Domain.Entities;

namespace SupportHub.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(u => u.AssignedUserRoles)
                .WithOne(ur => ur.AssignedByUser)
                .HasForeignKey(ur => ur.AssignedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(u => u.AssignedTickets)
                .WithOne(t => t.AssignedAgent)
                .HasForeignKey(t => t.AssignedAgentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
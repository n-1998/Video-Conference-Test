using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Discussion> Discussions { get; set; }

        public DbSet<DiscussionParticipant> DiscussionParticipants { get; set; }

        public DbSet<Participant> participants { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using FriendlyFireApi.Models;

namespace FriendlyFireApi.Models
{
    public class FriendlyFireContext : DbContext
    { 
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Player> Players { get; set; } 
        public DbSet<Session> PlayerResult { get; set; }

        public FriendlyFireContext(DbContextOptions<FriendlyFireContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<PlayerResult>()
                .HasKey(x => new { x.PlayerId, x.SessionId });
            builder.Entity<PlayerResult>()
                .HasOne(x => x.Player)
                .WithMany(pr => pr.History)
                .HasForeignKey(x => x.PlayerId);
            builder.Entity<PlayerResult>()
                .HasOne(x => x.Session)
                .WithMany(s => s.Results)
                .HasForeignKey(x => x.SessionId);
        }
    }
}

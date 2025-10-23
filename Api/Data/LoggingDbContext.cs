using Api.Models.Logging;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class LoggingDbContext : DbContext
{
    public LoggingDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<LogEntry> Logs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LogEntry>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Timestamp).IsRequired();
            entity.Property(e => e.Level).IsRequired();
            entity.Property(e => e.Message).IsRequired();
            entity.HasIndex(e => e.Timestamp);
            entity.HasIndex(e => e.Level);
        });
    }
}

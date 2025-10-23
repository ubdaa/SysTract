using Api.Models.Application;
using Api.Models.Logging;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    // Logging
    public DbSet<LogEntry> Logs { get; set; }
    
    // Application
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<CalendarConfig> CalendarConfigs { get; set; }
    public DbSet<Line> Lines { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<TractionPlace> TractionPlaces { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Logging entity configurations
        modelBuilder.Entity<LogEntry>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Timestamp).IsRequired();
            entity.Property(e => e.Level).IsRequired();
            entity.Property(e => e.Message).IsRequired();
            entity.HasIndex(e => e.Timestamp);
            entity.HasIndex(e => e.Level);
        });
        
        // Application entity configurations
        modelBuilder.Entity<Line>()
            .Property(l => l.Type)
            .HasConversion<string>();

        modelBuilder.Entity<Line>()
            .HasMany(l => l.Schedules)
            .WithOne(s => s.Line)
            .HasForeignKey(s => s.LineId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Line>()
            .HasMany(l => l.TractionPlaces)
            .WithOne(tp => tp.Line)
            .HasForeignKey(tp => tp.LineId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Calendar>()
            .HasMany(c => c.Configs)
            .WithOne(cc => cc.Calendar)
            .HasForeignKey(cc => cc.CalendarId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
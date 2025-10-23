using Api.Data.Configurations;
using Api.Models.Application;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<CalendarConfig> CalendarConfigs { get; set; }
    public DbSet<Line> Lines { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema(SchemaConfiguration.Application);
        
        modelBuilder.Entity<Line>()
            .Property(l => l.Type)
            .HasConversion<string>();

        modelBuilder.Entity<Line>()
            .HasMany(l => l.Schedules)
            .WithOne()
            .HasForeignKey(s => s.LineId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Calendar>()
            .HasMany(c => c.Configs)
            .WithOne()
            .HasForeignKey(cc => cc.CalendarId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
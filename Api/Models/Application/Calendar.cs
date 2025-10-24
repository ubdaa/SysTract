using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Api.Models.Application;

[Table("calendar")]
public class Calendar
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("path")]
    public required string Path { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("file_updated_at")]
    public DateTime FileUpdatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdateAt { get; set; }
    
    [Column("content")]
    public JsonDocument Content { get; set; } = null!;
    
    public ICollection<CalendarConfig> Configs { get; set; } = new List<CalendarConfig>();
}
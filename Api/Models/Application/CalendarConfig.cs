using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models.Application;

[Table(("calendar_configs"))]
public class CalendarConfig
{
    [Column("id")]
    public Guid Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    
    [Column("calendar_id")]
    public Guid CalendarId { get; set; }
    public Calendar? Calendar { get; set; }
}
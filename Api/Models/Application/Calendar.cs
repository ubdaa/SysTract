using System.Text.Json;

namespace Api.Models.Application;

public class Calendar
{
    public Guid Id { get; set; }
    public required string Path { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime FileUpdatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public JsonDocument Content { get; set; } = null!;
    public ICollection<CalendarConfig> Configs { get; set; } = new List<CalendarConfig>();
}
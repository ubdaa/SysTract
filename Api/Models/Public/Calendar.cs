using System.Text.Json;

namespace Api.Models.Public;

public class CalendarConfig
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}

public class Calendar
{
    public Guid Id { get; set; }
    public required string Path { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime FileUpdatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public JsonDocument Json { get; set; }
    public List<CalendarConfig> Configs { get; set; }
}
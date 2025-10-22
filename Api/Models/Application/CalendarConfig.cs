namespace Api.Models.Application;

public class CalendarConfig
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
    public Guid CalendarId { get; set; }
    public Calendar? Calendar { get; set; }
}
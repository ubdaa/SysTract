namespace Api.Models.Application;

public class Schedule
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Day { get; set; }
    public string? HalfDay { get; set; }
    public string? Night { get; set; }
    public string? Offbeat { get; set; }
    
    public Guid? LineId { get; set; }
    public Line? Line { get; set; }
}
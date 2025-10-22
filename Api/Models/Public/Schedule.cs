namespace Api.Models.Public;

public class Schedule
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Day { get; set; }
    public string? HalfDay { get; set; }
    public string? Night { get; set; }
    public string? Offbeat { get; set; }
}
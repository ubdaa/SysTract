namespace Api.Models.Application;

public class TractionPlace
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
    public Guid? LineId { get; set; }
    public Line? Line { get; set; }
}
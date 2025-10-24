using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models.Application;

[Table(("schedule"))]
public class Schedule
{
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("name")]
    public required string Name { get; set; }
    
    [Column("day")]
    public string? Day { get; set; }
    
    [Column("half_day")]
    public string? HalfDay { get; set; }

    [Column("night")] 
    public string? Night { get; set; }
    
    [Column("offbeat")]
    public string? Offbeat { get; set; }
    
    [Column("line_id")]
    public Guid? LineId { get; set; }
    public Line? Line { get; set; }
}
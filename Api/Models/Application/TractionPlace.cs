using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models.Application;

[Table("traction_places")]
public class TractionPlace
{
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("name")]
    public required string Name { get; set; }
    
    public Guid? LineId { get; set; }
    public Line? Line { get; set; }
}
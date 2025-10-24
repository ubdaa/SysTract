using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models.Application;

public enum LineType
{
    Principale,
    Secondaire,
}

[Table("line")]
public class Line
{
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("name")]
    public required string Name { get; set; }
    
    [Column("type")]
    public LineType Type { get; set; }
    
    [Column("path")]
    public required string Path { get; set; }
    
    [Column("column_output")]
    [MaxLength(5)]
    public required string ColumnOutput { get; set; }
    
    [Column("first_van")]
    public required string FirstVan { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    public ICollection<TractionPlace> TractionPlaces { get; set; } = new List<TractionPlace>();
}
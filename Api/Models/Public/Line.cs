namespace Api.Models.Public;

public enum LineType
{
    Principale,
    Secondaire,
}

public class Line
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public LineType Type { get; set; }
    public required string Chemin { get; set; }
    public required string ColumnOutput { get; set; }
    public required string FirstVan { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
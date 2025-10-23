using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models.Logging;

[Table("logs")]
public class LogEntry
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
        
    [Column("timestamp")]
    public DateTime Timestamp { get; set; }
        
    [Column("level")]
    [MaxLength(50)]
    public string Level { get; set; }
        
    [Column("message")]
    public string Message { get; set; }
        
    [Column("exception")]
    public string? Exception { get; set; }
        
    [Column("logger_name")]
    [MaxLength(255)]
    public string? LoggerName { get; set; }
        
    [Column("request_path")]
    [MaxLength(500)]
    public string? RequestPath { get; set; }
}
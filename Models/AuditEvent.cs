namespace FincoreBlazorClient.Models;

public class AuditEvent
{
    public string EventId { get; set; } = string.Empty;
    public string Actor { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string Module { get; set; } = string.Empty;
    public string Result { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
}

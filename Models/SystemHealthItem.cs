namespace FincoreBlazorClient.Models;

public class SystemHealthItem
{
    public string ServiceName { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Detail { get; set; } = string.Empty;
    public int LatencyMs { get; set; }
    public DateTime CheckedAtUtc { get; set; }
}

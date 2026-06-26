namespace FincoreBlazorClient.Models;

public class AuthSessionState
{
    public bool IsAuthenticated { get; set; }
    public string Email { get; set; } = string.Empty;
    public DateTime? LoggedAtUtc { get; set; }
}

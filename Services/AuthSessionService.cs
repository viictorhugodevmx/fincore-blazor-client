using FincoreBlazorClient.Models;

namespace FincoreBlazorClient.Services;

public class AuthSessionService
{
    private AuthSessionState SessionState { get; set; } = new();

    public AuthSessionState GetSession()
    {
        return SessionState;
    }

    public bool Login(string email, string password)
    {
        var isValidUser =
            email.Equals("victor@fincoreblazor.dev", StringComparison.OrdinalIgnoreCase)
            && password == "Password123";

        if (!isValidUser)
        {
            return false;
        }

        SessionState = new AuthSessionState
        {
            IsAuthenticated = true,
            Email = email,
            LoggedAtUtc = DateTime.UtcNow
        };

        return true;
    }

    public void Logout()
    {
        SessionState = new AuthSessionState();
    }
}

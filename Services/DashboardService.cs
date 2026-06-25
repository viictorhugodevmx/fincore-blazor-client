using FincoreBlazorClient.Models;

namespace FincoreBlazorClient.Services;

public class DashboardService
{
    public DashboardAccount GetDashboardAccount()
    {
        return new DashboardAccount
        {
            CustomerName = "Víctor Hugo Segundo Aguilar",
            AccountNumber = "ACC-1001",
            AvailableBalance = 24750.80m,
            Currency = "MXN",
            PendingTransfers = 3,
            RiskLevel = "Low"
        };
    }

    public List<RecentMovement> GetRecentMovements()
    {
        return new List<RecentMovement>
        {
            new RecentMovement
            {
                Type = "Deposit",
                Description = "Depósito nómina",
                Amount = 12500,
                Currency = "MXN",
                CreatedAtUtc = DateTime.UtcNow.AddDays(-2)
            },
            new RecentMovement
            {
                Type = "Withdrawal",
                Description = "Pago tarjeta digital",
                Amount = 850.75m,
                Currency = "MXN",
                CreatedAtUtc = DateTime.UtcNow.AddDays(-1)
            },
            new RecentMovement
            {
                Type = "Transfer",
                Description = "Transferencia SPEI recibida",
                Amount = 3200,
                Currency = "MXN",
                CreatedAtUtc = DateTime.UtcNow.AddHours(-8)
            }
        };
    }
}

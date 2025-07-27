namespace Hjp.Shared.Dto.Admin.Users.Balance.History
{
    public class AdminUserBalanceHistoryResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required AdminUserBalanceHistoryResponseItem[] History { get; set; }
    }
}
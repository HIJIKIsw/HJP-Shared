namespace Hjp.Shared.Dto.Me.Balance.History
{
    public class UserBalanceHistoryResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required UserBalanceHistoryResponseItem[] History { get; set; }
    }
}
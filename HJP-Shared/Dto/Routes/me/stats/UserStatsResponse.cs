namespace Hjp.Shared.Dto.Me.Stats
{
    public class UserStatsResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required int TotalDeposit { get; set; }
        public required int TotalWithdraw { get; set; }
        public required int TotalTransfer { get; set; }
    }
}
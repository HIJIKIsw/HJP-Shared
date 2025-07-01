namespace Hjp.Shared.Dto
{
    public class UserStatsResponse
    {
        public ulong DiscordUserId { get; set; }
        public int TotalDeposit { get; set; }
        public int TotalWithdraw { get; set; }
        public int TotalTransfer { get; set; }
    }
}
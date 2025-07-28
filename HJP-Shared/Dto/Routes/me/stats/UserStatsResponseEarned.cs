namespace Hjp.Shared.Dto.Me.Stats
{
    public class UserStatsResponseEarned
    {
        public required int TotalServerActivityReward { get; set; }
        public required int TotalLotteryReward { get; set; }
        public required int TotalTransfer { get; set; }
        public required int Others { get; set; }
        public required UserStatsResponseApplication[] ApplicationTotals { get; set; }
    }
}
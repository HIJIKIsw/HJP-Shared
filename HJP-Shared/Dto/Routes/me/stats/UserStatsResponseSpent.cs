namespace Hjp.Shared.Dto.Me.Stats
{
    public class UserStatsResponseSpent
    {
        public required int TotalLotteryPurchase { get; set; }
        public required int TotalTransfer { get; set; }
        public required int Others { get; set; }
        public required UserStatsResponseApplication[] ApplicationTotals { get; set; }
    }
}
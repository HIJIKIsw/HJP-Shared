namespace Hjp.Shared.Dto.Me.Stats
{
    public class UserStatsResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required UserStatsResponseEarned Earned { get; set; }
        public required UserStatsResponseSpent Spent { get; set; }
    }
}
namespace Hjp.Shared.Dto.Me.Stats
{
    public class UserStatsResponseApplication
    {
        public required int ApplicationId { get; set; }
        public required string Name { get; set; }
        public required string? IconUrl { get; set; }
        public required int Amount { get; set; }
    }
}
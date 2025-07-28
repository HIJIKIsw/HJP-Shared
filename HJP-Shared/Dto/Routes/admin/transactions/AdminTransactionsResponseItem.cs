namespace Hjp.Shared.Dto.Admin.Transactions
{
    public class AdminTransactionsResponseItem
    {
        public required int TransactionTypeId { get; set; }
        public required string IntegrationApplicationName { get; set; }
        public required int IntegrationApplicationId { get; set; }
        public required bool IsIntegrationApplicationVisible { get; set; }
        public required string? IntegrationApplicationIconUrl { get; set; }
        public required string? FromUserName { get; set; }
        public required ulong? FromDiscordUserId { get; set; }
        public required string? FromUserAvatarUrl { get; set; }
        public required string? ToUserName { get; set; }
        public required ulong? ToDiscordUserId { get; set; }
        public required string? ToUserAvatarUrl { get; set; }
        public required int Amount { get; set; }
        public required int? ToUserBalanceAfter { get; set; }
        public required int? FromUserBalanceAfter { get; set; }
        public required string? Description { get; set; }
        public required DateTime DateTime { get; set; }
    }
}
namespace Hjp.Shared.Dto.Admin.Transactions
{
    public class AdminTransactionsResponseItem
    {
        public required int TransactionTypeId { get; set; }
        public required string? FromUserName { get; set; }
        public required ulong? FromDiscordUserId { get; set; }
        public required string? ToUserName { get; set; }
        public required ulong? ToDiscordUserId { get; set; }
        public required int Amount { get; set; }
        public required int? ToUserBalanceAfter { get; set; }
        public required int? FromUserBalanceAfter { get; set; }
        public required string? Description { get; set; }
        public required DateTime DateTime { get; set; }
    }
}
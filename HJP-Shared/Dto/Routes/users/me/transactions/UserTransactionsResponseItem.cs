namespace Hjp.Shared.Dto.Users.Me.Transactions
{
    public class UserTransactionsResponseItem
    {
        public required int TransactionTypeId { get; set; }
        public required string? FromUserName { get; set; }
        public required ulong? FromDiscordUserId { get; set; }
        public required string? ToUserName { get; set; }
        public required ulong? ToDiscordUserId { get; set; }
        public required int Amount { get; set; }
        public required string? Description { get; set; }
        public required DateTime DateTime { get; set; }
    }
}
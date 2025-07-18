namespace Hjp.Shared.Dto.Users.Me.Transactions
{
    // TODO: ユーザ目線では、自身の情報は不要なので、in/outのフラグとcounterpartyの情報だけ渡すようにしてもよいかも
    public class UserTransactionsResponseItem
    {
        public required int TransactionTypeId { get; set; }
        public required string? FromUserName { get; set; }
        public required ulong? FromDiscordUserId { get; set; }
        public required string? FromUserAvatarUrl { get; set; }
        public required string? ToUserName { get; set; }
        public required ulong? ToDiscordUserId { get; set; }
        public required string? ToUserAvatarUrl { get; set; }
        public required int Amount { get; set; }
        public required int BalanceAfter { get; set; }
        public required string? Description { get; set; }
        public required DateTime DateTime { get; set; }
    }
}
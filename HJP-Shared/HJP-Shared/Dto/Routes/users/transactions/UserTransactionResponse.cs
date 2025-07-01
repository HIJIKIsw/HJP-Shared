using Hjp.Shared.Entities;

namespace Hjp.Shared.Dto
{
    public class UserTransactionResponse
    {
        public class Container
        {
            public int TransactionTypeId { get; set; }
            public string? FromUserName { get; set; }
            public ulong? FromDiscordUserId { get; set; }
            public string? ToUserName { get; set; }
            public ulong? ToDiscordUserId { get; set; }
            public int Amount { get; set; }
            public string? Description { get; set; }
            public DateTime DateTime { get; set; }

            public Container(UserCurrencyTransaction transaction)
            {
                this.TransactionTypeId = transaction.TransactionTypeId;
                this.FromUserName = transaction.FromUser?.Name;
                this.FromDiscordUserId = transaction.FromUser?.DiscordUserId;
                this.ToUserName = transaction.ToUser?.Name;
                this.ToDiscordUserId = transaction.ToUser?.DiscordUserId;
                this.Amount = transaction.Amount;
                this.Description = transaction.Description;
                this.DateTime = transaction.CreatedAt;
            }
        }

        public List<UserTransactionResponse.Container> Transactions { get; private set; } = new();

        public UserTransactionResponse(IEnumerable<UserCurrencyTransaction> transactions)
        {
            foreach (var transaction in transactions)
            {
                this.Transactions.Add(new UserTransactionResponse.Container(transaction));
            }
        }
    }
}
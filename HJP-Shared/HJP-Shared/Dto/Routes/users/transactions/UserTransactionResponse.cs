using Hjp.Shared.Entities;

namespace Hjp.Shared.Dto
{
    public class UserTransactionResponse
    {
        public class Container
        {
            public required int TransactionTypeId { get; set; }
            public string? FromUserName { get; set; }
            public ulong? FromDiscordUserId { get; set; }
            public string? ToUserName { get; set; }
            public ulong? ToDiscordUserId { get; set; }
            public required int Amount { get; set; }
            public string? Description { get; set; }
            public required DateTime DateTime { get; set; }
        }

        public required List<UserTransactionResponse.Container> Transactions { get; set; }
    }
}
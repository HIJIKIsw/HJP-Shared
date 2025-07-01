namespace Hjp.Shared.Dto
{
    public class UserTransactionResponse
    {
        public required List<UserTransactionResponseItem> Transactions { get; set; }
    }
}
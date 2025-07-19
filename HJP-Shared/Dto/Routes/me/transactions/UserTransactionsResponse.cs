namespace Hjp.Shared.Dto.Me.Transactions
{
    public class UserTransactionsResponse
    {
        public required List<UserTransactionsResponseItem> Transactions { get; set; }
    }
}
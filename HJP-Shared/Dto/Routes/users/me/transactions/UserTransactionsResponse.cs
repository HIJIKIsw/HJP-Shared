namespace Hjp.Shared.Dto.Users.Me.Transactions
{
    public class UserTransactionsResponse
    {
        public required List<UserTransactionsResponseItem> Transactions { get; set; }
    }
}
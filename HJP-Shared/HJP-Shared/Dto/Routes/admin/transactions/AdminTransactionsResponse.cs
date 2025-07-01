using Hjp.Shared.Entities;

namespace Hjp.Shared.Dto.Admin
{
    public class AdminTransactionsResponse : UserTransactionResponse
    {
        public AdminTransactionsResponse(IEnumerable<UserCurrencyTransaction> transactions) : base(transactions)
        {
            // Nothing to do.
        }
    }
}
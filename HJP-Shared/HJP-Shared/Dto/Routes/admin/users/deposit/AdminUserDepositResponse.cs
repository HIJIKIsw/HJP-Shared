namespace Hjp.Shared.Dto.Admin
{
    public class AdminUserDepositResponse : UserDepositResponse
    {
        public AdminUserDepositResponse(int beforeAmount, int afterAmount) : base(beforeAmount, afterAmount)
        {
            // Nothing to do.
        }
    }
}
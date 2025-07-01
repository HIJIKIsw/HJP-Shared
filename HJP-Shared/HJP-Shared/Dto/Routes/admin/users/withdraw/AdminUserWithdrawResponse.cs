namespace Hjp.Shared.Dto.Admin
{
    public class AdminUserWithdrawResponse : UserWithdrawResponse
    {
        public AdminUserWithdrawResponse(int beforeAmount, int afterAmount) : base(beforeAmount, afterAmount)
        {
            // Nothing to do.
        }
    }
}
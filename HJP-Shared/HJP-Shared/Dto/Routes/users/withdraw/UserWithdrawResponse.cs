namespace Hjp.Shared.Dto
{
    public class UserWithdrawResponse
    {
        public int BeforeAmount { get; set; }
        public int AfterAmount { get; set; }

        public UserWithdrawResponse(int beforeAmount, int afterAmount)
        {
            this.BeforeAmount = beforeAmount;
            this.AfterAmount = afterAmount;
        }
    }
}
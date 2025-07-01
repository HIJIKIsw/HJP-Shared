namespace Hjp.Shared.Dto
{
    public class UserDepositResponse
    {
        public int BeforeAmount { get; set; }
        public int AfterAmount { get; set; }

        public UserDepositResponse(int beforeAmount, int afterAmount)
        {
            this.BeforeAmount = beforeAmount;
            this.AfterAmount = afterAmount;
        }
    }
}
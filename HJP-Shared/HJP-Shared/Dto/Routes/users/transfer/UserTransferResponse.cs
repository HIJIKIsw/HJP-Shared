namespace Hjp.Shared.Dto
{
    public class UserTransferResponse
    {
        public int BeforeAmount { get; set; }
        public int AfterAmount { get; set; }

        public UserTransferResponse(int beforeAmount, int afterAmount)
        {
            this.BeforeAmount = beforeAmount;
            this.AfterAmount = afterAmount;
        }
    }
}
namespace Hjp.Shared.Dto.Me.Deposit
{
    public class UserDepositRequest
    {
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
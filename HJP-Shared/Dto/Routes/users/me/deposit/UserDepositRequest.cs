namespace Hjp.Shared.Dto.Users.Me.Deposit
{
    public class UserDepositRequest
    {
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
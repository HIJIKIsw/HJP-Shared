namespace Hjp.Shared.Dto.Users.Me.Withdraw
{
    public class UserWithdrawRequest
    {
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
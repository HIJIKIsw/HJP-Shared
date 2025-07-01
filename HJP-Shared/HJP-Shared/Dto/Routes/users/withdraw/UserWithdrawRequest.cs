namespace Hjp.Shared.Dto.Users.Withdraw
{
    public class UserWithdrawRequest
    {
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
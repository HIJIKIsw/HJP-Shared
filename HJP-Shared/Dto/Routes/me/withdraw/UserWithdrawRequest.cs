namespace Hjp.Shared.Dto.Me.Withdraw
{
    public class UserWithdrawRequest
    {
        public required int ApplicationId { get; set; }
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
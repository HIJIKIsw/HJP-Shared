namespace Hjp.Shared.Dto
{
    public class UserWithdrawRequest
    {
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
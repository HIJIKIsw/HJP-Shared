namespace Hjp.Shared.Dto
{
    public class UserDepositRequest
    {
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
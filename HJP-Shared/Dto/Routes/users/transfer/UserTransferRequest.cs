namespace Hjp.Shared.Dto.Users.Transfer
{
    public class UserTransferRequest
    {
        public required ulong ToDiscordUserId { get; set; }
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
namespace Hjp.Shared.Dto.Users.Me.Transfer
{
    public class UserTransferRequest
    {
        public required ulong ToDiscordUserId { get; set; }
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
namespace Hjp.Shared.Dto.Me.Transfer
{
    public class UserTransferRequest
    {
        public required int ApplicationId { get; set; }
        public required ulong ToDiscordUserId { get; set; }
        public required int Amount { get; set; }
        public string? Description { get; set; }
    }
}
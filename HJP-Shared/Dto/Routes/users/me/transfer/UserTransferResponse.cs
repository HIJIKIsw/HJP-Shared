namespace Hjp.Shared.Dto.Users.Me.Transfer
{
    public class UserTransferResponse
    {
        public required ulong ToDiscordUserId { get; set; }
        public required int BeforeAmount { get; set; }
        public required int AfterAmount { get; set; }
    }
}
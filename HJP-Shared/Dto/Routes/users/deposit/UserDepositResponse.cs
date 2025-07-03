namespace Hjp.Shared.Dto.Users.Deposit
{
    public class UserDepositResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required int BeforeAmount { get; set; }
        public required int AfterAmount { get; set; }
    }
}
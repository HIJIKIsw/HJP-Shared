namespace Hjp.Shared.Dto.Users.Withdraw
{
    public class UserWithdrawResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required int BeforeAmount { get; set; }
        public required int AfterAmount { get; set; }
    }
}
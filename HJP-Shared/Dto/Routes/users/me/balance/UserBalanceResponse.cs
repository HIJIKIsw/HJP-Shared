namespace Hjp.Shared.Dto.Users.Me.Balance
{
    public class UserBalanceResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required int Amount { get; set; }
    }
}
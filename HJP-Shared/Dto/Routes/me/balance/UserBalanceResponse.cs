namespace Hjp.Shared.Dto.Me.Balance
{
    public class UserBalanceResponse
    {
        public required ulong DiscordUserId { get; set; }
        public required int Amount { get; set; }
    }
}
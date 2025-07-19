using Hjp.Shared.Dto.Me.Withdraw;

namespace Hjp.Shared.Dto.Admin.Users.Withdraw
{
    public class AdminUserWithdrawResponse : UserWithdrawResponse
    {
        public required ulong DiscordUserId { get; set; }
    }
}
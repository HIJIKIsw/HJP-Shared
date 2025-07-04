using Hjp.Shared.Dto.Users.Me.Deposit;

namespace Hjp.Shared.Dto.Admin.Users.Deposit
{
    public class AdminUserDepositResponse : UserDepositResponse
    {
        public required ulong DiscordUserId { get; set; }
    }
}
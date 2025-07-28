using Hjp.Shared.Dto.Me.Deposit;

namespace Hjp.Shared.Dto.Moderator.Users.ServerActivityReward
{
    public class ModeratorServerActivityRewardResponse : UserDepositResponse
    {
        public required ulong DiscordUserId { get; set; }
    }
}
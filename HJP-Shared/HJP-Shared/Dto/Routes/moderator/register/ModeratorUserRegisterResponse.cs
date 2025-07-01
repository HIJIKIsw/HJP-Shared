namespace Hjp.Shared.Dto.Moderator
{
    public class ModeratorUserRegisterResponse
    {
        public string? UserName { get; set; }
        public ulong DiscordUserId { get; set; }

        public ModeratorUserRegisterResponse(string userName, ulong discordUserId)
        {
            this.UserName = userName;
            this.DiscordUserId = discordUserId;
        }
    }
}
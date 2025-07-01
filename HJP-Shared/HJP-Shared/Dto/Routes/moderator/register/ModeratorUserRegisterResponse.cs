namespace Hjp.Shared.Dto.Moderator
{
    public class ModeratorUserRegisterResponse
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
    }
}
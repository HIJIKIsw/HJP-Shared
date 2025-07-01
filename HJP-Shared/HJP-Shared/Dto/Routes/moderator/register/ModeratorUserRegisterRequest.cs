namespace Hjp.Shared.Dto.Moderator
{
    public class ModeratorUserRegisterRequest
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
    }
}
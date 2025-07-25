namespace Hjp.Shared.Dto.Moderator.Users.Register
{
    public class ModeratorUserRegisterRequest
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
        public required string AvatarUrl { get; set; }
        public bool IsSystemUser { get; set; } = false;
    }
}
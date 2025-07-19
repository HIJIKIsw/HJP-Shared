namespace Hjp.Shared.Dto.Me
{
    public class UserResponse
    {
        public required string Name { get; set; }
        public required ulong DiscordUserId { get; set; }
        public required string AvatarUrl { get; set; }
    }
}
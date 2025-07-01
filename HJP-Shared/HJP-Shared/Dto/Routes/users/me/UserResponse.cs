namespace Hjp.Shared.Dto
{
    public class UserResponse
    {
        public required string Name { get; set; }
        public required ulong DiscordUserId { get; set; }
    }
}
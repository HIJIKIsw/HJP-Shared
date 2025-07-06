namespace Hjp.Shared.Dto.Users.Login
{
    public class UserLoginResponse
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
        public required string AvatarUrl { get; set; }
    }
}
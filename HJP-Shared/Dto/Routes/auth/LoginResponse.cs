namespace Hjp.Shared.Dto.Routes.auth
{
    public class LoginResponse
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
        public required string AvatarUrl { get; set; }
        public required string Signature { get; set; }
    }
}
namespace Hjp.Shared.Dto
{
    public class UserLoginResponse
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
    }
}
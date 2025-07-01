namespace Hjp.Shared.Dto
{
    public class UserLoginResponse
    {
        public string UserName { get; set; } = null!;
        public ulong DiscordUserId { get; set; }
    }
}
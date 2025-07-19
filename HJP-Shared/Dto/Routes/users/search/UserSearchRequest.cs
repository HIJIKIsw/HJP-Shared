namespace Hjp.Shared.Dto.Users.Search
{
    public class UserSearchRequest
    {
        public string? UserName { get; set; }
        public bool IsPartialMatchUserName { get; set; }
        public ulong? DiscordUserId { get; set; }
        public bool IsPartialMatchDiscordUserId { get; set; }
    }
}
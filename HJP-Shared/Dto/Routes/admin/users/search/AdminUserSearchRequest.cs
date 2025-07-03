
namespace Hjp.Shared.Dto.Admin.Users.Search
{
    public class AdminUserSearchRequest
    {
        public string? UserName { get; set; }
        public bool IsPartialMatchUserName { get; set; }
        public ulong? DiscordUserId { get; set; }
        public bool IsPartialMatchDiscordUserId { get; set; }
    }
}
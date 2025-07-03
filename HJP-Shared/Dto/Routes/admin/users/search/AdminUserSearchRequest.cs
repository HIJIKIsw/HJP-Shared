
namespace Hjp.Shared.Dto.Admin.Users.Search
{
    public class AdminUserSearchRequest
    {
        public string UserName { get; set; } = null!;
        public bool IsPartialMatchUserName { get; set; } = false;
        public ulong DiscordUserId { get; set; }
        public bool IsPartialMatchDiscordUserId { get; set; } = false;
    }
}
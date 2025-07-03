
namespace Hjp.Shared.Dto.Admin.Users.Search
{
    public class AdminUserSearchRequest
    {
        public required string? UserName { get; set; }
        public required bool? IsPartialMatchUserName { get; set; } = false;
        public required ulong? DiscordUserId { get; set; }
        public required bool? IsPartialMatchDiscordUserId { get; set; } = false;
    }
}
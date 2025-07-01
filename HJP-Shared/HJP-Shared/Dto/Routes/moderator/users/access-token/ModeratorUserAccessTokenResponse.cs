namespace Hjp.Shared.Dto.Moderator.Users.AccessToken
{
    public class ModeratorUserAccessTokenResponse
    {
        public required string Token { get; set; }
        public required ulong DiscordUserId { get; set; }
    }
}
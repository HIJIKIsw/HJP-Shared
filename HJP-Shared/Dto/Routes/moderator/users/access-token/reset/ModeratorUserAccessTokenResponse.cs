namespace Hjp.Shared.Dto.Moderator.Users.AccessToken.Reset
{
    public class ModeratorUserAccessTokenResetResponse
    {
        public required string Token { get; set; }
        public required ulong DiscordUserId { get; set; }
    }
}
namespace Hjp.Shared.Dto.Moderator.Users.AccessToken.Reset
{
    public class ModeratorUserAccessTokenResetRequest
    {
        public required string? UserName { get; set; }
        public required string? AvatarUrl { get; set; }
    }
}
namespace Hjp.Shared.Constants
{
    public static class ApiConstants
    {
        public const string AuthenticationScheme = "Bearer";

        public static class HeaderNames
        {
            public const string Nonce = "X-Nonce";
        }

        public static class ClaimTypes
        {
            private const string Prefix = "Hjp.Api.";

            public const string UserName = Prefix + "UserName";
            public const string DiscordUserId = Prefix + "DiscordUserId";
            public const string AvatarUrl = Prefix + "AvatarUrl";
            public const string PermissionTypeId = Prefix + "PermissionTypeId";
        }
    }
}
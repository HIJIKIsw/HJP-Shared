using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Auth
{
    public class LoginResponse
    {
        public required string UserName { get; set; }
        public required ulong DiscordUserId { get; set; }
        public required string AvatarUrl { get; set; }
        public required PermissionType PermissionTypeId { get; set; }
        public required string Signature { get; set; }
    }
}
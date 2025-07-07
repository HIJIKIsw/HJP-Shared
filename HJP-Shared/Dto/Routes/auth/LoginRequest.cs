using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Routes.auth
{
    public class LoginRequest
    {
        public required string AccessToken { get; set; }
        public PermissionType? AsPermissionTypeId { get; set; }
    }
}
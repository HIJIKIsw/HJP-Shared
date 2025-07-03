using Hjp.Shared.Dto.Users.Me;
using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Admin.Users
{
    public class AdminUserResponse : UserResponse
    {
        public required int CurrencyAmount { get; set; }
        public required PermissionType PermissionTypeId { get; set; }
    }
}
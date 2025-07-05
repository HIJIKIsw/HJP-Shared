using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hjp.Shared.Enums
{
    public enum PermissionType
    {
        None = 0,

        [Display(Name = "一般ユーザ")]
        User,

        [Display(Name = "モデレータ")]
        Moderator,

        [Display(Name = "管理者")]
        Admin,
    }

    public static class PermissionTypeExtensions
    {
        public static string GetDisplayName(this PermissionType permissionType) => permissionType.GetType().GetField(permissionType.ToString())!.GetCustomAttribute<DisplayAttribute>()!.Name!;
        public static int ToInt(this PermissionType permissionType) => (int)permissionType;
    }
}
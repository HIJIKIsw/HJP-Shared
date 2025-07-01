namespace Hjp.Shared.Entities
{
    public class UserPermission : BaseTable
    {
        public int Id { get; set; }
        public required int PermissionTypeId { get; set; }
        public PermissionTypeMaster PermissionType { get; set; } = null!;
        public required int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

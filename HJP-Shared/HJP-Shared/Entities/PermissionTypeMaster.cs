using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class PermissionTypeMaster
    {
        public int Id { get; set; }
        [StringLength(32)]
        public required string Code { get; set; }
        [StringLength(32)]
        public string? Name { get; set; }

    }
}

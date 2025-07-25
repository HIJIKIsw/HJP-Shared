using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class User : BaseTable
    {
        public int Id { get; set; }
        [StringLength(128)]
        public required string Name { get; set; }
        public required ulong DiscordUserId { get; set; }
        [Url]
        [StringLength(512)]
        public required string AvatarUrl { get; set; }
        public bool IsSystemUser { get; set; }
    }
}
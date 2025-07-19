using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class Notice : BaseTable
    {
        public int Id { get; set; }
        [StringLength(128)]
        public required string Title { get; set; } = default!;
        public required string Body { get; set; } = default!;
        public DateTime? PublishedAt { get; set; }
        public bool IsRemoved { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class IntegrationApplication : BaseTable
    {
        public int Id { get; set; }
        [StringLength(128)]
        public required string Name { get; set; }
        public required int ApplicationId { get; set; }
        public required string? IconUrl { get; set; }
        public bool IsVisible { get; set; }
    }
}

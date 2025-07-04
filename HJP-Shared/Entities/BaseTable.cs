using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public abstract class BaseTable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; } = null!;
    }
}
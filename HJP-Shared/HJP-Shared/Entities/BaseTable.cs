namespace Hjp.Shared.Entities
{
    public abstract class BaseTable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
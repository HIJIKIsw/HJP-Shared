namespace Hjp.Shared.Entities
{
    public class Notice : BaseTable
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Body { get; set; } = default!;
        public DateTime? PublishedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
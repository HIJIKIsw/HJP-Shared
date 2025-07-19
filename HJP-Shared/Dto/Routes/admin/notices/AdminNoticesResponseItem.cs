namespace Hjp.Shared.Dto.Admin.Notices
{
    public class AdminNoticesResponseItem
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime? PublishedAt { get; set; }
        public required bool IsRemoved { get; set; }
    }
}

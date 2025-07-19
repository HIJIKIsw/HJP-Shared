namespace Hjp.Shared.Dto.Admin.Notices
{
    public class AdminNoticePostRequest
    {
        public required string Title { get; set; }
        public required string Body { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}

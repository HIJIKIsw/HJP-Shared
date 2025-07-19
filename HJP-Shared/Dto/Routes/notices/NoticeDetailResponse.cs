namespace Hjp.Shared.Dto.Notices
{
    public class NoticeDetailResponse
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }
        public required DateTime DateTime { get; set; }
    }
}

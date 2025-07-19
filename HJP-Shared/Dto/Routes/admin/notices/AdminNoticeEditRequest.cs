namespace Hjp.Shared.Dto.Admin.Notices
{
    public class AdminNoticesEditRequest : AdminNoticePostRequest
    {
        public required int Id { get; set; }
        public required bool IsRemoved { get; set; }
    }
}
namespace Hjp.Shared.Dto.Admin.Notices
{
    public class AdminNoticesEditRequest : AdminNoticePostRequest
    {
        public required bool IsRemoved { get; set; }
    }
}
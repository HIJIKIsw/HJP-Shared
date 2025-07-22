namespace Hjp.Shared.Dto.Admin.Notices
{
    public class AdminNoticeEditRequest : AdminNoticePostRequest
    {
        public required bool IsRemoved { get; set; }
    }
}
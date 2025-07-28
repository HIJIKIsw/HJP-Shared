namespace Hjp.Shared.Dto.Admin.Notices
{
    public class AdminNoticesResponse
    {
        public required AdminNoticesResponseItem[] Notices { get; set; } = default!;
    }
}

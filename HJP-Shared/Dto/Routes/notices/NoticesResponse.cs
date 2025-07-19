namespace Hjp.Shared.Dto.Notices
{
    public class NoticesResponse
    {
        public required NoticesResponseItem[] Notices { get; set; } = default!;
    }
}

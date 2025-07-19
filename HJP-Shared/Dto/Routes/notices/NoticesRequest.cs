using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Notices
{
    public class NoticesRequest
    {
        public const int MaxNoticeGetCount = 500;

        /// <summary>
        /// 並び順
        /// </summary>
        public SortOrder? Sort { get; set; } = SortOrder.Descending;
        /// <summary>
        /// 取得開始位置
        /// </summary>
        public int? Offset { get; set; }
        /// <summary>
        /// 取得件数
        /// </summary>
        /// <value>1~500</value>
        public int? Limit { get; set; }
    }
}

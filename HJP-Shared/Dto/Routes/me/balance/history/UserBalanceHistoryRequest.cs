using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Me.Balance.History
{
    public class UserBalanceHistoryRequest
    {
        /// <summary>
        /// 取得開始日
        /// </summary>
        public DateOnly? From { get; set; }
        /// <summary>
        /// 取得終了日
        /// </summary>
        public DateOnly? To { get; set; }
        /// <summary>
        /// 並び順
        /// </summary>
        public SortOrder? Sort { get; set; } = SortOrder.Descending;
    }
}
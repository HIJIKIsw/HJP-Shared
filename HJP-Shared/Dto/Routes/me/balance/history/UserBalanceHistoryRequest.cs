using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Me.Balance.History
{
    public class UserBalanceHistoryRequest
    {
        /// <summary>
        /// タイムゾーン
        /// </summary>
        /// <remarks>
        /// 日次の取引履歴を取得する際に使用するタイムゾーン。
        /// レスポンスで返る日時はUTCである点に注意。
        /// </remarks>
        public required TimeZoneInfo TimeZone { get; set; }
        /// <summary>
        /// 取得開始日
        /// </summary>
        public required DateOnly From { get; set; }
        /// <summary>
        /// 取得終了日
        /// </summary>
        public required DateOnly To { get; set; }
        /// <summary>
        /// 並び順
        /// </summary>
        public SortOrder? Sort { get; set; } = SortOrder.Ascending;
    }
}
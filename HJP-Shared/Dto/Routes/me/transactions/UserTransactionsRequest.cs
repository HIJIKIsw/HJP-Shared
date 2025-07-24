using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Me.Transactions
{
    public class UserTransactionsRequest
    {
        public const int MaxTransactionGetCount = 500;

        /// <summary>
        /// 取引種別
        /// </summary>
        public TransactionType[]? Types { get; set; }
        /// <summary>
        /// 取得開始日
        /// </summary>
        public DateTime? From { get; set; }
        /// <summary>
        /// 取得終了日
        /// </summary>
        public DateTime? To { get; set; }
        /// <summary>
        /// 取引相手のDiscordUserId
        /// </summary>
        public ulong? Counterparty { get; set; }
        /// <summary>
        /// 取得ユーザから見た取引方向
        /// </summary>
        public TransactionDirection? Direction { get; set; } = TransactionDirection.All;
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
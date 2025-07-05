using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Admin.Transactions
{
    public class AdminTransactionsRequest
    {
        public const int MaxTransactionGetCount = 1000;

        /// <summary>
        /// 取引種別
        /// </summary>
        public List<TransactionType>? Types { get; set; }
        /// <summary>
        /// 取引に関連するユーザのDiscordUserId
        /// </summary>
        public List<ulong>? RelatedDiscordUserIds { get; set; }
        /// <summary>
        /// 送金者のDiscordUserId
        /// </summary>
        public ulong? FromDiscordUserId { get; set; }
        /// <summary>
        /// 受取者のDiscordUserId
        /// </summary>
        public ulong? ToDiscordUserId { get; set; }
        /// <summary>
        /// 取得開始日
        /// </summary>
        public DateTime? From { get; set; }
        /// <summary>
        /// 取得終了日
        /// </summary>
        public DateTime? To { get; set; }
        /// <summary>
        /// 並び順
        /// </summary>
        /// <value>"asc", "desc"</value>
        public SortOrder? Sort { get; set; } = SortOrder.Descending;
        /// <summary>
        /// 取得開始位置
        /// </summary>
        public int? Offset { get; set; }
        /// <summary>
        /// 取得件数
        /// </summary>
        /// <value>1~1000</value>
        /// <remarks>default: 1000</remarks>
        public int? Limit { get; set; } = AdminTransactionsRequest.MaxTransactionGetCount;

    }
}
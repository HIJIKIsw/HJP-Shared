using Hjp.Shared.Enums;

namespace Hjp.Shared.Dto.Users.Me.Transactions
{
    public class UserTransactionsRequest
    {
        public const string DirecitonAll = "all";
        public const string DirectionIn = "in";
        public const string DirectionOut = "out";
        public const string SortAsc = "asc";
        public const string SortDesc = "desc";
        public const int MaxTransactionGetCount = 500;

        /// <summary>
        /// 取引種別
        /// </summary>
        public List<TransactionType>? Types { get; set; }
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
        /// 取引方向
        /// </summary>
        /// <value>"all", "in", "out"</value>
        public string? Direction { get; set; } = UserTransactionsRequest.DirecitonAll;
        /// <summary>
        /// 並び順
        /// </summary>
        /// <value>"asc", "desc"</value>
        public string? Sort { get; set; } = UserTransactionsRequest.SortDesc;
        /// <summary>
        /// 取得開始位置
        /// </summary>
        public int? Offset { get; set; }
        /// <summary>
        /// 取得件数
        /// </summary>
        /// <value>1~500</value>
        /// <remarks>default: 500</remarks>
        public int? Limit { get; set; } = UserTransactionsRequest.MaxTransactionGetCount;
    }
}
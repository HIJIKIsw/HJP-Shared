using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hjp.Shared.Enums
{
    public enum TransactionType
    {
        None = 0,

        [Display(Name = "活動で得た")]
        UserDeposit,

        [Display(Name = "使用")]
        UserWithdraw,

        [Display(Name = "システムによる付与")]
        SystemDeposit,

        [Display(Name = "システムによる減額")]
        SystemWithdraw,

        [Display(Name = "ユーザー間送ポ")]
        UserTransfer,

        [Display(Name = "くじの購入/当選")]
        UserLottery
    }

    public static class TransactionTypeExtensions
    {
        public static string GetDisplayName(this TransactionType transactionType) => transactionType.GetType().GetField(transactionType.ToString())!.GetCustomAttribute<DisplayAttribute>()!.Name!;
        public static int ToInt(this TransactionType transactionType) => (int)transactionType;
        public static List<int> ToIntList(this IEnumerable<TransactionType> transactionTypes) => transactionTypes.Select(x => x.ToInt()).ToList();
    }
}
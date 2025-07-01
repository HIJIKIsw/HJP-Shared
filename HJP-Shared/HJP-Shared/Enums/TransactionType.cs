using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hjp.Shared.Enums
{
    public enum TransactionType
    {
        None = 0,

        [Display(Name = "ユーザによる入金")]
        UserDeposit,

        [Display(Name = "ユーザによる出金")]
        UserWithdraw,

        [Display(Name = "システムからの付与")]
        SystemDeposit,

        [Display(Name = "システムによる減額")]
        SystemWithdraw,

        [Display(Name = "ユーザ間送金")]
        UserTransfer,
    }

    public static class TransactionTypeExtensions
    {
        public static string GetDisplayName(this TransactionType transactionType) => transactionType.GetType().GetField(transactionType.ToString())!.GetCustomAttribute<DisplayAttribute>()!.Name!;
        public static int ToInt(this TransactionType transactionType) => (int)transactionType;
        public static List<int> ToIntList(this IEnumerable<TransactionType> transactionTypes) => transactionTypes.Select(x => x.ToInt()).ToList();
    }
}
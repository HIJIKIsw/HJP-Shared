using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class UserCurrencyTransaction : BaseTable
    {
        public int Id { get; set; }
        public required int TransactionTypeId { get; set; }
        public TransactionTypeMaster TransactionType { get; set; } = null!;
        public required int IntegrationApplicationId { get; set; }
        public IntegrationApplication IntegrationApplication { get; set; } = null!;
        public int? FromUserId { get; set; }
        public User? FromUser { get; set; }
        public int? ToUserId { get; set; }
        public User? ToUser { get; set; }
        public int Amount { get; set; }
        public int? FromUserBalanceAfter { get; set; }
        public int? ToUserBalanceAfter { get; set; }
        [StringLength(128)]
        public string? Description { get; set; }
    }
}
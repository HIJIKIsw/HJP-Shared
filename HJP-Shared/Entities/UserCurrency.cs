namespace Hjp.Shared.Entities
{
    public class UserCurrency : BaseTable
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public required User Owner { get; set; }
        public int Amount { get; set; }
    }
}
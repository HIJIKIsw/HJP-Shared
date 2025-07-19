namespace Hjp.Shared.Dto.Me.Lottery
{
    public class UserLotteryResponse
    {
        public required bool IsWin { get; set; }
        public required int BeforeAmount { get; set; }
        public required int AfterAmount { get; set; }
        public required int BankAmount { get; set; }
        public required string Message { get; set; }
    }
}
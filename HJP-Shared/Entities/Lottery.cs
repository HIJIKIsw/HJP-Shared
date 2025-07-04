using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class LotteryMetric
    {
        public int Id { get; set; }
        [StringLength(128)]
        public required string Key { get; set; }
        public required int Value { get; set; }
    }
}
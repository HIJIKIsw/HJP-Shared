using System.ComponentModel.DataAnnotations;

namespace Hjp.Shared.Entities
{
    public class UserAccessToken : BaseTable
    {
        public int Id { get; set; }
        [StringLength(44)]
        public required string Token { get; set; }
        public required int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
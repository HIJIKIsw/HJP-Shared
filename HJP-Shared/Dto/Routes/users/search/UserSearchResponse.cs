using Hjp.Shared.Dto.Me;

namespace Hjp.Shared.Dto.Users.Search
{
    public class UserSearchResponse
    {
        public required UserResponse[] Users { get; set; }
    }
}
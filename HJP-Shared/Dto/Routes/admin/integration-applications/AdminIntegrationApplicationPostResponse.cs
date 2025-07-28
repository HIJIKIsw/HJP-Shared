namespace Hjp.Shared.Dto.Admin.IntegrationApplications
{
    public class AdminIntegrationApplicationPostResponse
    {
        public required int ApplicationId { get; set; }
        public required string Name { get; set; }
        public required string? IconUrl { get; set; }
        public required bool IsVisible { get; set; }
    }
}
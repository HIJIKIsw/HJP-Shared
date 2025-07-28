namespace Hjp.Shared.Dto.Admin.IntegrationApplications
{
    public class AdminIntegrationApplicationRegisterRequest
    {
        public required int ApplicationId { get; set; }
        public required string Name { get; set; }
        public required string? IconUrl { get; set; }
        public required bool IsVisible { get; set; }
    }
}
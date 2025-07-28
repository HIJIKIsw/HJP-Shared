namespace Hjp.Shared.Dto.Admin.IntegrationApplications
{
    public class AdminIntegrationApplicationsResponseItem
    {
        public required string ApplicationId { get; set; }
        public required string Name { get; set; }
        public required string IconUrl { get; set; }
        public required bool IsVisible { get; set; }
    }
}
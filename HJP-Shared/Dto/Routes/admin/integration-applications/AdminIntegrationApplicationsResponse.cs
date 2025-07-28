namespace Hjp.Shared.Dto.Admin.IntegrationApplications
{
    public class AdminIntegrationApplicationsResponse
    {
        public required AdminIntegrationApplicationsResponseItem[] Applications { get; set; } = default!;
    }
}
namespace Hjp.Shared.Dto.Admin.IntegrationApplications
{
    public class AdminIntegrationApplicationEditRequest
    {
        public required string Name { get; set; }
        public required string IconUrl { get; set; }
        public required bool IsVisible { get; set; }
    }
}
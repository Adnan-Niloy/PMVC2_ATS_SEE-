namespace AssetTracker.Core.Models
{
    public class OrganizationBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

    }
}

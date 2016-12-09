using AssetTracker.Core.Models;
using System.Data.Entity;

namespace AssetTracker.Core.Context
{
    public class AssetDbContext : DbContext
    {
        public AssetDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationBranch> OrganizationBranches { get; set; }

    }
}

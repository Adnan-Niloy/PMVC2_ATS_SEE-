using AssetTracker.Core.Models;
using System.Data.Entity;

namespace AssetTracker.Core.Context
{
    public class AssetDbContext : DbContext
    {
        //public AssetDbContext()
        //{
        //    Configuration.LazyLoadingEnabled = false;
        //}

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationBranch> OrganizationBranches { get; set; }
        public DbSet<GeneralCategory> GeneralCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    }
}

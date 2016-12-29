using AssetTracker.Core.Context;
using AssetTracker.Core.DAL.BaseDAL;
using AssetTracker.Core.Models;
using AssetTracker.Core.Models.Interfaces.DAL;
using System;
using System.Data.Entity;

namespace AssetTracker.Core.DAL
{
    public class OrganizationBranchRepository : BaseRepository<OrganizationBranch>, IOrganizationBranchRepository, IDisposable
    {
        
        public OrganizationBranchRepository(DbContext db) : base(new AssetDbContext())
        {
            base._context = db;
        }

        public AssetDbContext Context
        {
            get
            {
                return _context as AssetDbContext;
            } 
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}

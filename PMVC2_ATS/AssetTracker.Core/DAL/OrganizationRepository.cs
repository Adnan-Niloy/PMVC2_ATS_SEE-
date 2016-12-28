using AssetTracker.Core.Context;
using AssetTracker.Core.Models;
using AssetTracker.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AssetTracker.Core.Models.Interfaces.DAL;
using AssetTracker.Core.DAL.BaseDAL;




namespace AssetTracker.Core.DAL
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganizationRepository, IDisposable
    {
        public AssetDbContext Context
        {
            get
            {
                return _context as AssetDbContext;
            }
        }

        public OrganizationRepository(DbContext db) : base(new AssetDbContext())
        {
            base._context = db;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public ICollection<Organization> SearchByCriteria()
        {
            throw new NotImplementedException();
        }
    }
}

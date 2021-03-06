﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models.Interfaces.BaseInterface;

namespace AssetTracker.Core.Models.Interfaces.DAL
{
    public interface IOrganizationRepository : IRepository<Organization>
    {
        ICollection<Organization> SearchByCriteria();
    }
}

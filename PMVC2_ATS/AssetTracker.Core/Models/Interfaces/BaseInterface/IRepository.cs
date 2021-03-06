﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models.Interfaces.BaseInterface
{
    public interface IRepository<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        ICollection<T> GetAll();
        T GetById(int id);

        ICollection<T> Get(Expression<Func<T, bool>> predicate);
    }
}

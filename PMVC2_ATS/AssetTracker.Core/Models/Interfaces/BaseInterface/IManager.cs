using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models.Interfaces.BaseInterface
{
    public interface IManager<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);

        ICollection<T> GetAll();
        T GetById(int id);
    }
}

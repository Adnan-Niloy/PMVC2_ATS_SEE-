using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models.Interfaces.BaseInterface;
using System.Data.Entity;

namespace AssetTracker.Core.DAL.BaseDAL
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {

        public DbContext _context;

        public DbSet<T> Table
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public BaseRepository(DbContext db)
        {
            this._context = db;
        }

        public bool Add(T entity)
        {
            Table.Add(entity);
            int row = _context.SaveChanges();
            return row > 0;
        }

        public ICollection<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public bool Update(T entity)
        {

            Table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}

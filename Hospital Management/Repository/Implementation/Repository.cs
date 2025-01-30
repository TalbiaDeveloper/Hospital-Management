using Hospital_Management.Data;
using Hospital_Management.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hospital_Management.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbset;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbset = _db.Set<T>();
        }

        void IRepository<T>.Add(T entity)
        {
            dbset.Add(entity); 
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbset;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            IQueryable<T> query = dbset;
            return query.ToList();
        }

        void IRepository<T>.Remove(T entity)
        {
            dbset.Remove(entity);
        }


        void IRepository<T>.Update(T entity)
        {
            dbset.Update(entity);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

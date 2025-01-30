using System.Linq.Expressions;

namespace Hospital_Management.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Save();
        void Remove(T entity);
    }
}

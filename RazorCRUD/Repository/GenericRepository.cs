using Microsoft.EntityFrameworkCore;
using RazorCRUD.Data;
using RazorCRUD.Interfaces;

namespace RazorCRUD.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected CustomerDBContext _context;
        protected DbSet<T> dbSet;
        public GenericRepository(
            CustomerDBContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        public async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }
        public async Task<T?> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }
        public async Task<bool> Remove(int id)
        {
            var t = await dbSet.FindAsync(id);
            if (t != null)
            {
                dbSet.Remove(t);
                return true;
            }
            else
                return false;
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}

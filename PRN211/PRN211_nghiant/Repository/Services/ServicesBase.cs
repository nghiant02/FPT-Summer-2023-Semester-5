using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Services
{
    public class ServicesBase<T> where T : class
    {
        BankAccountTypeContext _context;
        DbSet<T> _dbSet;

        public ServicesBase()
        {
            _context = new BankAccountTypeContext();
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public bool Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

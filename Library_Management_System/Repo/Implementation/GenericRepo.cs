using Library_Management_System.Data;
using Library_Management_System.Repo.Interface;

namespace Library_Management_System.Repo.Implementation
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {

        private readonly AppDbContext _context;

        public GenericRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
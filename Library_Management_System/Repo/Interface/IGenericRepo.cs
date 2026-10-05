namespace Library_Management_System.Repo.Interface
{
    public interface IGenericRepo<T> where T : class
    {

        IEnumerable<T> GetAll();

        T? GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }

}
using Library_Management_System.Data;
using Library_Management_System.Models;
using Library_Management_System.Repo.Interface;

namespace Library_Management_System.Repo.Implementation
{
    public interface IUnitOfWork
    {
        IGenericRepo<Book> Books { get; }
        IGenericRepo<Borrowing> Borrowings { get; }
        IGenericRepo<Member> Members { get; }
        IGenericRepo<Category> Categories { get; }
      
    
        int Save();
    }
}

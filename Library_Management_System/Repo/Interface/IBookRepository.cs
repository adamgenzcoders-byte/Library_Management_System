using Library_Management_System.Models;

namespace Library_Management_System.Repo.Interface
{
    public interface IBookRepository : IGenericRepo<Book>
    {
        
            bool IsIsbnUnique(string isbn);
            IEnumerable<Book> SearchBooks(string keyword);
            Book? GetMostExpensiveBook();
        }

    }



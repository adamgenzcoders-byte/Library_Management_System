using Library_Management_System.Data;
using Library_Management_System.Models;
using Library_Management_System.Repo.Implementation;
using Library_Management_System.Repo.Interface;


public class BookRepo : GenericRepo<Book> , IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepo(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public bool IsIsbnUnique(string isbn)
    {
        return !_context.Books.Any(b => b.ISBN == isbn);
    }

    public IEnumerable<Book> SearchBooks(string keyword)
    {
        return _context.Books
            .Where(b => b.Title.ToLower().Contains(keyword.ToLower()) ||
                        b.Author.ToLower().Contains(keyword.ToLower()))
            .OrderBy(b => b.Title)
            .ToList();
    }

    public Book? GetMostExpensiveBook()
    {
        return _context.Books
            .OrderByDescending(b => b.Price)
            .FirstOrDefault();
    }
}

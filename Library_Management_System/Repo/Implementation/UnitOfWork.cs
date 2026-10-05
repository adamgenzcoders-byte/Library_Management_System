using Library_Management_System.Data;
using Library_Management_System.Models;

using Library_Management_System.Data;
using Library_Management_System.Repo.Interface;

namespace Library_Management_System.Repo.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IGenericRepo<Book> Books { get; }
        public IGenericRepo<Borrowing> Borrowings { get; }
        public IGenericRepo<Member> Members { get; }
        public IGenericRepo<Category> Categories { get; }
        public UnitOfWork(AppDbContext context,IGenericRepo<Category> categories , IGenericRepo<Book> books , IGenericRepo<Borrowing> borrowings , IGenericRepo<Member> members)
        { 
            _context = context;
            Categories = categories;
            Books = books;
            Borrowings = borrowings;
            Members = members;
        

        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
    }

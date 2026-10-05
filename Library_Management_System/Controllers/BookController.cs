using Library_Management_System.Models;
using Library_Management_System.Repo.Implementation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public BookController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

   
}

using System.ComponentModel.DataAnnotations;
using Library_Management_System.Repo;

public class CreateBookDto
{
    [Required]
    public string Title { get; set; } 

    [Required]
    public string Author { get; set; }

    [Required]
    public string ISBN { get; set; } 

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    public int CategoryId { get; set; }
}

public class BookSearchResponseDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public decimal Price { get; set; }
}





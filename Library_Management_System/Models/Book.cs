using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Library_Management_System.Models


{
    
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } 

        [Required]
        public string Author { get; set; } 

        [Required]
        public string ISBN { get; set; } 

        [Required]
        [Range(0.01, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; } = true;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }

}

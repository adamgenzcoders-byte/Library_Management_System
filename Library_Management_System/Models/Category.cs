namespace Library_Management_System.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

}

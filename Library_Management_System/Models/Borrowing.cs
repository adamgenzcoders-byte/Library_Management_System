using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System.Models
{

    public class Borrowing
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required]
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        public Member? Member { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book? Book { get; set; }
    }

}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreRazorPages.Models
{
    [Table("tbl_Books")]
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Book Name required")]  // ann validate null values
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabets are allowed.")]
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Qty { get; set; }
        public DateTime IssueDate { get; set; }

        public bool Status { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WebAppCoreRazorPages.Models
{

    [Table("tbl_Annotations")]

    [Index(nameof(Email), IsUnique = true)]  // no duplication 
    public class AllAnnotationExample
    {
        [Key]
        public int ID { get; set; }  // cluster

        [Required(ErrorMessage = "First Name Required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Plz Enter Only Alphabets")]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [MaxLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }  // Index uniqur and Index


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]  //****
        [Compare("Password", ErrorMessage = "Password MisMatch")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public DateTime Dob { get; set; }

        [Range(18, 50, ErrorMessage = "Age Must be in Between 18 to 50")]
        public int Age { get; set; }


        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Only digits are allowed.")]
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }


        [StringLength(20)]  // not less than so
        public string Address { get; set; }

        public bool Status { get; set; }
    }
}

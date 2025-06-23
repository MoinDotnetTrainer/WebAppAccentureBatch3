using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreRazorPages.Models
{

    [Index(nameof(Email))]

    [Index(nameof(PhoneNumber), IsUnique = true)]

    public class Anno
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "First name cannot be more than 20 characters.")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabets are allowed.")]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string? LastName { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        public string? PhoneNumber { get; set; }

        [Required]
        [Range(18, 50, ErrorMessage = "Age must be between 18 and 60.")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [NotMapped]
        public string? ConfirmPassword { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public string? Dept { get; set; }




    }
}

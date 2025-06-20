using System.ComponentModel.DataAnnotations;

namespace WebAppCoreRazorPages.Models
{
    public class UsersData
    {
        [Key] // pk and Identity
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

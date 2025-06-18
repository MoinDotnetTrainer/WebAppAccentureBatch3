using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreRazorPages.Models
{
    [Table("Employees")]
    public class UserValues  // uservales as a table 
    {
        [Key] // indicates Pk and Auto increment
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}

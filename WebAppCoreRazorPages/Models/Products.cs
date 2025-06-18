using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreRazorPages.Models
{

    [Table("Tbl_products")]
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        public string PName { get; set; }

        public int Qty { get; set; }
    }
}

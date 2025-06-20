using System.ComponentModel.DataAnnotations;

namespace WebAppCoreRazorPages.Models
{
    
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        
        public string OrderName { get; set; }
        public int Qty { get; set; }
    }
}

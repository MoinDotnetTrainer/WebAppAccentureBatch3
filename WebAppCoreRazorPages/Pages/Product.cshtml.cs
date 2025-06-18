using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class ProductModel : PageModel
    {

        AppDb _db;
        public ProductModel() {
            _db = new AppDb();
        }
        [BindProperty]
        public Products _product { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() {
            if (_product!=null)
            {
                _db.Add(_product);
                int res = _db.SaveChanges();
                if (res>0)
                {
                    TempData["res"] = "Saved Products";
                }
            }
        }
    }
}

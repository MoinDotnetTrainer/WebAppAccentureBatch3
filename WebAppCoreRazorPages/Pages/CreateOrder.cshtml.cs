using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class CreateOrderModel : PageModel
    {

        AppDb _db;
        public CreateOrderModel() {
            _db = new AppDb();
        }

        [BindProperty]
        public Orders _Orders { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() {
            if (_Orders!=null)
            {
                _db.Add(_Orders);
                int res = _db.SaveChanges();
                if (res>0)
                {
                    TempData["res"] = "Saved!";
                }
            }
        }
    }
}

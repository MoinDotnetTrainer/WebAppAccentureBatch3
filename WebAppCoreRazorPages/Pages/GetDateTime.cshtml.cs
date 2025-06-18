using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppCoreRazorPages.Pages
{
    public class GetDateTimeModel : PageModel
    {
        // onget executes on form load
        public void OnGet()
        {
            TempData["res"] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  
        }

        public void OnPost() {
            TempData["res"] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}

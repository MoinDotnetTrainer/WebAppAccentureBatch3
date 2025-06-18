using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class MulModel : PageModel
    {
        [BindProperty]
        public MyValues prop1 { get; set; }

        //15 prop
        public void OnGet()
        {
            TempData["res"] = "No Res ";
        }

        public void OnPost()
        {
            int z = prop1.x * prop1.y;
            TempData["res"] = " Res " + z;
        }
    }
}

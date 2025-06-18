using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppCoreRazorPages.Pages
{
    public class SubModel : PageModel
    {
        [BindProperty]
        public int x { get; set; }

        [BindProperty]
        public int y { get; set; }

        //15 prop
        public void OnGet()
        {
            TempData["res"]= "No Res ";     
        }

        public void OnPost()
        {
            int z = x - y;
            TempData["res"] = " Res " + z;
        }
    }
}

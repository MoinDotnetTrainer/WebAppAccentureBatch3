using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppCoreRazorPages.Pages
{
    public class AddModel : PageModel
    {
        public int x { get; set; }
        public int y { get; set; }
        public void OnGet()
        {
            TempData["res"] = "No Res ";
        }

        public void OnPost()
        {

            // request . form
            x = Convert.ToInt32(Request.Form["num1"].ToString());
            y = Convert.ToInt32(Request.Form["num2"].ToString());
            int z = x + y;
            TempData["res"] = " Res " + z;
        }
    }
}

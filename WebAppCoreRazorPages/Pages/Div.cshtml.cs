using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class DivModel : PageModel
    {


        //15 prop
        public void OnGet()
        {
            TempData["res"] = "No Res ";
        }

        public void OnPost(MyValues obj)
        {
            int z = obj.x / obj.y;
            TempData["res"] = " Res " + z;
        }
    }
}

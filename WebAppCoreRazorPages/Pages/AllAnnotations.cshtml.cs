using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class AllAnnotationsModel : PageModel
    {

        AppDb _db;
        public AllAnnotationsModel()
        {
            _db = new AppDb();
        }


        [BindProperty]
        public AllAnnotationExample _Ex { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid)  // a
                {
                    if (_Ex != null)
                    {
                        _db.allAnnotationExamples.Add(_Ex);
                        int res = _db.SaveChanges();
                        if (res > 0)
                        {
                            return RedirectToPage("/Display");
                        }
                        else
                        {
                            return Page();
                        }
                    }
                }
                else
                {
                    TempData["res"] = "Model Values are Not fully Added";
                }
            }
            catch (Exception ex)
            {
                TempData["res"] = ex.Message;
            }


            return Page();

        }
    }
}

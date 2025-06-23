using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class AnnotationsModel : PageModel
    {

        AppDb _db;
        public AnnotationsModel()
        {
            _db = new AppDb();
        }

        [BindProperty]
        public Anno _ano { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            try
            {

           
            if (ModelState.IsValid)  // verfiy that model is passing all its annotation
            {
                if (_ano != null)
                {
                    _db.annos.Add(_ano);
                    int res = _db.SaveChanges();
                    if (res > 0)
                    {
                        TempData["res"] = "ano Saved Successfully";
                        // automatically redirect to Books list page

                        return RedirectToPage("DisplayData");
                    }
                }
                else
                {
                    TempData["res"] = "Error in Saving";
                }
            }
            else
            {
                TempData["res"] = "Model is not valid, please check the data you entered.";
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

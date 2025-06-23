using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class EditModel : PageModel
    {
        AppDb _Db;
        public EditModel()
        {
            _Db = new AppDb();
        }


        [BindProperty]
        public AllAnnotationExample _Ex { get; set; }
        public void OnGet(int Id)
        {
            // on get 

            /// getting the data from database
            /// 
            _Ex = _Db.allAnnotationExamples.FirstOrDefault(x => x.ID == Id);
        }

        public ActionResult OnPost()
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _Db.Attach(_Ex).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    int res = _Db.SaveChanges();
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
            catch (Exception)
            {

                throw;
            }
            return Page();
        }
    }
}

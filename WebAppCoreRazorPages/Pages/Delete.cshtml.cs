using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class DeleteModel : PageModel
    {

        AppDb _Db;
        public DeleteModel()
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

        public ActionResult OnPost(int Id)
        {

            var data = _Db.allAnnotationExamples.Find(Id);
            if (data != null)
            {
                _Db.Remove(data);
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
            return Page();

        }
    }
}

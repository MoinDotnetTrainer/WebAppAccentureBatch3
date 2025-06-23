using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class DisplayModel : PageModel
    {
        AppDb _db;
        public DisplayModel()
        {
            _db = new AppDb();
        }

        public IList<AllAnnotationExample> allAnnotationExamples { get; set; }
        public void OnGet()
        {
            allAnnotationExamples = (from s in _db.allAnnotationExamples select s).ToList();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class DisplayBooksModel : PageModel
    {
        AppDb _db;
        public DisplayBooksModel()
        {
            _db = new AppDb();
        }

        public IList<Book> displaybooks { get; set; } 
        public void OnGet()
        {
            displaybooks = (from s in _db.books where s.Status==true select s).ToList();  
        }
    }
}

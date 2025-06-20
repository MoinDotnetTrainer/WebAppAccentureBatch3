using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class BooksModel : PageModel
    {

        AppDb _db;
        public BooksModel()
        {
            _db = new AppDb();
        }

        [BindProperty]
        public Book _Books { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            if (ModelState.IsValid)  // verfiy that model is passing all its annotation
            {
                if (_Books != null)
                {
                    _db.books.Add(_Books);
                    int res = _db.SaveChanges();
                    if (res > 0)
                    {
                        TempData["res"] = "Book Saved Successfully";
                        // automatically redirect to Books list page

                        return RedirectToPage("DisplayBooks");
                    }
                }
                else
                {
                    TempData["res"] = "Error in Saving Book";
                }
            }
            else
            {
                TempData["res"] = "Model is not valid, please check the data you entered.";
            }
            return Page();
        }
    }
}
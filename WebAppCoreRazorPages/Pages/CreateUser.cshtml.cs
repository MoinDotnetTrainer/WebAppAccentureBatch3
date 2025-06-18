using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class CreateUserModel : PageModel
    {
        AppDb _db;
        public CreateUserModel()
        {
            _db = new AppDb();
        }
        [BindProperty]
        public UserValues _myvalues { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

            if (_myvalues != null)
            {
                _db.Add(_myvalues);
                int res = _db.SaveChanges();
                if (res > 0)
                {
                    TempData["res"] = "Data Inserted Successfully";
                    _myvalues = null;
                }
            }
        }
    }
}

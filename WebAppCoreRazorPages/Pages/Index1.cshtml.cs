using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreRazorPages.Models;

namespace WebAppCoreRazorPages.Pages
{
    public class Index1Model : PageModel
    {
        AppDb _db;
        public Index1Model()
        {
            _db = new AppDb();
        }

        [BindProperty]
        public UsersData _Users { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {


                var user = new UsersData
                {
                    UserName = _Users.UserName.ToUpper(),
                    Email = _Users.Email,
                    Password = _Users.Password
                };

                _db.usersData.Add(user);
                // _db.Add(_Users);
                int res = _db.SaveChanges();
                if (res > 0)
                {
                    TempData["res"] = "Inserted Successfully";
                }
            }
            else
            {
                TempData["res"] = "Error in Inserting Data";
            }   
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace inlabdbproj.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("password");
            HttpContext.Session.Clear();
            return RedirectToPage("/Browse");
        }
    }
}

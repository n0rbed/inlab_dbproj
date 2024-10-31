using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace inlabdbproj.Pages
{
    public class BrowseModel : PageModel
    {
        public string exists { get; set; }

        public void OnGet()
        {
            exists = string.IsNullOrEmpty(HttpContext.Session.GetString("username")) ? "0" : "1";
            
        }
    }
}

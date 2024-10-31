using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace inlabdbproj.Pages
{
    public class BrowseModel : PageModel
    {
        public bool exists { get; set; }

        public void OnGet()
        {
            exists = string.IsNullOrEmpty(HttpContext.Session.GetString("username"));
            
        }
    }
}

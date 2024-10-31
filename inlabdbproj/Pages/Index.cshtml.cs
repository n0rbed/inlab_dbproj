using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace inlabdbproj.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        [Required]
        public string username { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        [MinLength(3)]
        public string password { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPostLogin()
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || password.Length < 3)
            {
                return Page();
            }
            if (!username.Contains("a-") && !username.Contains("ad-") && !username.Contains("s-"))
            {
                return Page();
            }
            HttpContext.Session.SetString("username", username);
            HttpContext.Session.SetString("password", password);
            return RedirectToPage("/Browse");
        }
    }
}

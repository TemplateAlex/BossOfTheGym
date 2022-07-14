using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BossOfTheGym.Pages
{
    public class RegistrationPageModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Psswd { get; set; }

        [BindProperty]
        public string Rpsswd { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }
    }
}

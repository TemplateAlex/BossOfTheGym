using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BossOfTheGym.Pages
{
    public class CabinetPageModel : PageModel
    {
        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostLogin()
        {
            return RedirectToPage("Index");
        }
    }
}

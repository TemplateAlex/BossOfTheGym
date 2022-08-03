using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BossOfTheGym.Pages
{
    public class AuthModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostReg()
        {
            return Page();
        }

        public IActionResult OnPostLog()
        {
            return Page();
        }
    }
}

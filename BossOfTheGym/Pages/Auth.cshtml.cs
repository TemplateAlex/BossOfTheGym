using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BossOfTheGym.Pages
{
    public class AuthModel : PageModel
    {
        [BindProperty]
        public string EmailReg { get; set; }

        [BindProperty]
        public string NicknameReg { get; set; }

        [BindProperty]
        public string PsswdReg { get; set; }

        [BindProperty]
        public string RpsswdReg { get; set; }

        [BindProperty]
        public string NicknameLog { get; set; }

        [BindProperty]
        public string PsswdLog { get; set; }
        
        
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

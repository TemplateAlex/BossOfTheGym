using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BossOfTheGym.Pages
{
    public class ServicesModel : PageModel
    {

        public string? Category { get; private set; }
        public IActionResult OnGet(string category)
        {
            Category = category;

            if(Category != "Main" && Category != "Martial_Arts" && Category != "Online_Training")
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BossOfTheGym.Models;

namespace BossOfTheGym.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly BOTGDBContext _context;
        public List<Coacher> Coachers { get; private set; } = new List<Coacher>();
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

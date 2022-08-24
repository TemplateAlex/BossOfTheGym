using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BossOfTheGym.Models;

namespace BossOfTheGym.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly BOTGDBContext _context;

        public TypeCoacher? typeCoacher; 
        public List<Coacher> Coachers { get; private set; } = new List<Coacher>();
        public string? Category { get; private set; }

        public IActionResult OnGet(string category)
        {
            Category = category;

            if(Category != "Main" && Category != "Martial_Arts" && Category != "Online_Training")
            {
                this.typeCoacher = null;
                return RedirectToPage("Index");
            }


            if (Category == "Main")
            {
                this.typeCoacher = _context.TypeCoachers.FirstOrDefault(t => t.TypeCoacherName == "Base");
            }

            if (Category == "Martial_Arts")
            {
                this.typeCoacher = _context.TypeCoachers.FirstOrDefault(t => t.TypeCoacherName == "Martial Arts");
            }

            if (Category == "Online_Training")
            {
                this.typeCoacher = _context.TypeCoachers.FirstOrDefault(t => t.TypeCoacherName == "Online Training");
            }

            var personsGym = _context.PersonsGym.ToList();

            for (int i = 0; i < personsGym.Count; i++)
            {
                if (this.typeCoacher != null && this.typeCoacher.Id == personsGym[i].TypeCoacherId)
                {
                    Coachers.Add(_context.Coachers.FirstOrDefault(c => c.Id == personsGym[i].CoacherId));
                }
            }

            return Page();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using BossOfTheGym.Models;

namespace BossOfTheGym.Pages
{
    public class AuthModel : PageModel
    {
        private readonly BOTGDBContext _context;

        public bool isErrorEqualsPsswd;

        public bool isErrorUserExistReg;

        public bool isErrorUserLog;

        public bool isErrorRole;

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
        
        public AuthModel(BOTGDBContext db)
        {
            _context = db;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.Keys.Count() != 0) return RedirectToPage("Index");

            return Page();
        }

        public async Task<IActionResult> OnPostReg()
        {
            var userEmail = _context.Users.FirstOrDefault(u => u.EmailUser == EmailReg);
            var userNickname = _context.Users.FirstOrDefault(u => u.Nickname == NicknameReg);

            if (PsswdReg.Equals(RpsswdReg))
            {
                if (userEmail == null && userNickname == null)
                {
                    User user = new User();
                    user.Nickname = NicknameReg;
                    user.EmailUser = EmailReg;
                    user.Password = PsswdReg;
                    
                    try
                    {
                        user.RoleId = _context.Roles.First(r => r.RoleName == "user").Id;
                    }
                    catch(Exception exception)
                    {
                        throw new Exception("Error with role in DB");
                    }

                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("Index");
                }
                else
                {
                    isErrorUserExistReg = true;
                    return Page();
                }
            }

            isErrorEqualsPsswd = true;
            return Page();

        }

        public IActionResult OnPostLog()
        {
            var user = _context.Users.FirstOrDefault(u => u.Nickname == NicknameLog);
            Role role;

            if (user != null && user.Password == PsswdLog)
            {   
                try
                {
                    role = _context.Roles.First(r => r.Id == user.RoleId);
                }
                catch(Exception exception)
                {
                    throw new Exception("We have troubles with Roles in DB");
                }

                HttpContext.Session.SetString("nickname", user.Nickname);
                HttpContext.Session.SetString("role", role.RoleName);
                return RedirectToPage("Index");

            }

            isErrorUserLog = true;
            return Page();
        }
    }
}

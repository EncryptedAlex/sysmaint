using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sysmaintapp.Models;
using sysmaintapp.Services;
using System.Collections.Generic;

namespace sysmaintapp.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public UserRegister ObjUserRegister { get; set; } = new();

        public List<UserRegister> UserRegisters { get; set; }

        public void OnGet()
        {
            
            //UserRegisters = UserRegisterService.GetAll();
        }

        public IActionResult OnPostAsync()
        {
            UserRegisters = UserRegisterService.GetAll();
            if (!ModelState.IsValid)
            {
                
                return Page();
            }

            UserRegisterService.Add(ObjUserRegister);
            return RedirectToPage("Index");
        }
    }
}

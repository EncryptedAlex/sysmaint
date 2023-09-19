using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sysmaintapp.Models;


namespace sysmaintapp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public Usuario ObjUser {get;set;} = new Usuario();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {

        if (ObjUser.validar())
        {

            return RedirectToPage("MainOn");
        }
        else
        {
        
            TempData["MensajeLogin"] = "Datos de inicio de sesion incorrectos";
            return Page();
        }
    }

}

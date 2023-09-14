using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sysmaintapp.Models;

namespace sysmaintapp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public Usuario ObjetoUsuario {get;set;} = new Usuario();
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public IActionResult OnPost()
     {
        // Asigna el valor del parámetro id a la propiedad id de la clase

        if(ObjetoUsuario.validar())
        {
            TempData["MensajeCompra"] = "Inicio de Secion Correctamente";
            return RedirectToPage("Error");
        }else{
            TempData["MensajeLogin"] = "Datos de inicio de sesion incorrectos, intentelo de nuevo por favor";
            return Page();
        }
     }
}

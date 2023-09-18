using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sysmaintapp.Pages;

public class MainOnModel : PageModel
{
    private readonly ILogger<MainOnModel> _logger;

    public MainOnModel(ILogger<MainOnModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


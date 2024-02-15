using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMPS360Module5.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public ContactModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string info = "Email: nssurge@pointpark.edu";
        ViewData["info"] = info;
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMPS360Module5.Pages
{
    public class BlogModel : PageModel
    {
        private readonly ILogger<BlogModel> _logger;

        public BlogModel(ILogger<BlogModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string rambling = "Here is my blog, I will post random thoughts and ideas here.";
            ViewData["blog"] = rambling;
        }
    }
}

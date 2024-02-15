using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMPS360Module5.Pages;

public class PhotosModel : PageModel
{
    private readonly ILogger<PhotosModel> _logger;

    public PhotosModel(ILogger<PhotosModel> logger)
    {
        _logger = logger;
    }
    public List<string> PhotoUrls { get; set; }
    public void OnGet()
    {
         PhotoUrls = new List<string>
            {
                "/images/image1.jpg",
                "/images/image2.jpg",
                "/images/image3.jpg",
            };
    }
}


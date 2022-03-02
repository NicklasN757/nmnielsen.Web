using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace nmnielsen.Web.Pages;

public class AboutMeModel : PageModel
{
    public int Age { get; set; }

    public async Task<IActionResult> OnGet()
    {
        DateTime bornDate = DateTime.Parse("01-03-2000");
        DateTime currentDate = DateTime.Now;
        Age = currentDate.Year - bornDate.Year;

        return Page();
    }
}
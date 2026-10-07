using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_krutalevich.Data;
using wt_lab5_5razor_krutalevich.Models;

namespace wt_lab5_5razor_krutalevich.Pages.Flights;

public class DetailsModel : PageModel
{
    public Flight? Flight { get; set; }
    public IActionResult OnGet(int id)
    {
        Flight = FlightStore.Flights.FirstOrDefault(f => f.Id == id);

        if (Flight == null)
            return NotFound();   // HTTP 404

        return Page();
    }
}
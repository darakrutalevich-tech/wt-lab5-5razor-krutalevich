using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_krutalevich.Data;
using wt_lab5_5razor_krutalevich.Models;

namespace wt_lab5_5razor_krutalevich.Pages.Flights;

public class IndexModel : PageModel
{
    public List<Flight> Flights { get; set; } = new();
    public void OnGet()
    {
        Flights = FlightStore.Flights;
    }
}
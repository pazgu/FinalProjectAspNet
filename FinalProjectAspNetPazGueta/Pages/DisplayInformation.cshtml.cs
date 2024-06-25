using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProjectAspNetPazGueta.Pages
{
    public class DisplayInformationModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Information { get; set; }

        // Your code for fetching the information from the database and setting the 'Information' property goes here

        public void OnGet()
        {
            // Optional: If you need to perform any additional logic during GET requests
        }
    }
}

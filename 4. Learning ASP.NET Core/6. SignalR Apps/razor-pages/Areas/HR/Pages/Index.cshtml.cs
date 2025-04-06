using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.HR
{
    public class IndexModel : PageModel
    {
        // Add our new name and id params to properties so we can use them outside of the method
        
        // Method 1:
        // public string? Name { get; set; }
        // public int? Id { get; set; }

        // public void OnGet(string? name, int? id)
        // {
        //     Name = name;
        //     Id = id;
        // }

        // Method 2:
        [BindProperty (SupportsGet = true)]
        public string? Name { get; set; }
        [BindProperty (SupportsGet = true)]
        public int? Id { get; set; }

        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace chapter_challenge.NewPages
{
    public class IndexModel : PageModel
    {
        public string? Slug { get; set; }
        public void OnGet(string? slug)
        {
            Slug = slug;
        }
    }
}

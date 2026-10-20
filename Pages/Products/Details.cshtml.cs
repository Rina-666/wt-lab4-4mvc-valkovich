using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab4_4mvc_valkovich.Models;
using wt_lab4_4mvc_valkovich.Data;

namespace wt_lab4_4mvc_valkovich.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public Book? Book { get; set; }

        public IActionResult OnGet(int id)
        {
            Book = BookStore.Books.FirstOrDefault(b => b.Id == id);
            if (Book == null) return NotFound();
            return Page();
        }
    }
}
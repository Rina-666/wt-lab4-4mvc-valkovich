using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab4_4mvc_valkovich.Models;
using wt_lab4_4mvc_valkovich.Data;

namespace wt_lab4_4mvc_valkovich.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Book> Books { get; set; } = new();

        public void OnGet() // Обработчик GET-запроса
        {
            Books = BookStore.Books; // Берем данные из общего хранилища
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab4_4mvc_valkovich.Models;
using wt_lab4_4mvc_valkovich.Data;

namespace wt_lab4_4mvc_valkovich.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty] // Привязывает данные из формы к этому свойству
        public Book Book { get; set; } = new();

        public void OnGet() { } // Просто показываем страницу

        public IActionResult OnPost() // Обрабатываем отправку формы
        {
            if (!ModelState.IsValid) return Page(); // Если ошибки валидации - вернуть форму

            Book.Id = BookStore.Books.Any() ? BookStore.Books.Max(b => b.Id) + 1 : 1;
            BookStore.Books.Add(Book);

            return RedirectToPage("./Index"); // Переход на список
        }
    }
}
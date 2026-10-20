using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab4_4mvc_valkovich.Models;
using wt_lab4_4mvc_valkovich.Data;

namespace wt_lab4_4mvc_valkovich.Pages.Products
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; } = new();

        // Этот метод срабатывает, когда мы только открываем страницу (GET)
        public IActionResult OnGet(int id)
        {
            var existingBook = BookStore.Books.FirstOrDefault(b => b.Id == id);

            if (existingBook == null)
                return NotFound(); // Если книги с таким ID нет — ошибка 404

            Book = existingBook;
            return Page();
        }

        // Этот метод срабатывает, когда мы нажимаем "Сохранить" (POST)
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var existingBook = BookStore.Books.FirstOrDefault(b => b.Id == Book.Id);

            if (existingBook == null)
                return NotFound();

            // Обновляем все поля книги
            existingBook.Title = Book.Title;
            existingBook.Author = Book.Author;
            existingBook.Genre = Book.Genre;
            existingBook.Year = Book.Year;
            existingBook.Price = Book.Price;
            existingBook.Pages = Book.Pages;
            existingBook.ISBN = Book.ISBN;
            existingBook.ImageUrl = Book.ImageUrl;
            existingBook.Description = Book.Description;
            existingBook.IsAvailable = Book.IsAvailable;

            // Возвращаемся в каталог
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostDelete(int id)
        {
            var book = BookStore.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                BookStore.Books.Remove(book);
            }
            return RedirectToPage("./Index"); // Возвращаемся в каталог
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using wt_lab4_4mvc_valkovich.Models;

namespace wt_lab4_4mvc_valkovich.Controllers
{
    public class BookController : Controller
    {
        // GET: /Book/Index
        public IActionResult Index()
        {
            return View(LibraryData.Books);
        }

        // GET: /Book/Details/1
        public IActionResult Details(int id)
        {
            var book = LibraryData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        // GET: /Book/Create
        public IActionResult Create() => View();

        // POST: /Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = LibraryData.Books.Any() ? LibraryData.Books.Max(b => b.Id) + 1 : 1;
                LibraryData.Books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /Book/Edit/1
        public IActionResult Edit(int id)
        {
            var book = LibraryData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        // POST: /Book/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                var existing = LibraryData.Books.FirstOrDefault(b => b.Id == book.Id);
                if (existing == null) return NotFound();

                existing.Title = book.Title;
                existing.Author = book.Author;
                existing.Genre = book.Genre;
                existing.Year = book.Year;
                existing.Price = book.Price;
                existing.IsAvailable = book.IsAvailable;
                existing.Pages = book.Pages;
                existing.ISBN = book.ISBN;
                existing.Description = book.Description;

                return RedirectToAction("Index");
            }
            return View(book);
        }

        // POST: /Book/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var book = LibraryData.Books.FirstOrDefault(b => b.Id == id);
            if (book != null) LibraryData.Books.Remove(book);
            return RedirectToAction("Index");
        }
    }
}
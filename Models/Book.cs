using System.ComponentModel.DataAnnotations;

namespace wt_lab4_4mvc_valkovich.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название книги")]
        [StringLength(200, MinimumLength = 1)]
        [Display(Name = "Название")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите автора")]
        [Display(Name = "Автор")]
        public string Author { get; set; } = string.Empty;

        [Display(Name = "Жанр")]
        public string Genre { get; set; } = string.Empty;

        [Range(1, 5000, ErrorMessage = "Год должен быть от 1 до 5000")]
        [Display(Name = "Год издания")]
        public int Year { get; set; }

        [Range(0, 100000, ErrorMessage = "Некорректная цена")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "В наличии")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Количество страниц")]
        public int Pages { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = string.Empty;

        [Display(Name = "Описание")]
        public string Description { get; set; } = string.Empty;
    }
}
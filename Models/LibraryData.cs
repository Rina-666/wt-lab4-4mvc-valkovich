namespace wt_lab4_4mvc_valkovich.Models
{
    public static class LibraryData
    {
        public static readonly List<Book> Books = new()
        {
            new Book
            {
                Id = 1, Title = "Гордость и предубеждение", Author = "Джейн Остин",
                Genre = "Роман", Year = 1813, Price = 890, IsAvailable = true,
                Pages = 432, ISBN = "978-5-17-090000-1",
                Description = "Классический роман о любви и предрассудках."
            },
            new Book
            {
                Id = 2, Title = "Джейн Эйр", Author = "Шарлотта Бронте",
                Genre = "Роман воспитания", Year = 1847, Price = 750, IsAvailable = true,
                Pages = 512, ISBN = "978-5-17-090000-2",
                Description = "История гувернантки с сильным характером."
            },
            new Book
            {
                Id = 3, Title = "Грозовой перевал", Author = "Эмили Бронте",
                Genre = "Готический роман", Year = 1847, Price = 680, IsAvailable = false,
                Pages = 416, ISBN = "978-5-17-090000-3",
                Description = "Мрачная история любви на йоркширских болотах."
            },
            new Book
            {
                Id = 4, Title = "Маленькие женщины", Author = "Луиза Мэй Олкотт",
                Genre = "Драма", Year = 1868, Price = 620, IsAvailable = true,
                Pages = 384, ISBN = "978-5-17-090000-4",
                Description = "Тёплая история о четырёх сёстрах Марч."
            },
            new Book
            {
                Id = 5, Title = "Аня из Зелёных Мезонинов", Author = "Люси Мод Монтгомери",
                Genre = "Детская проза", Year = 1908, Price = 540, IsAvailable = true,
                Pages = 320, ISBN = "978-5-17-090000-5",
                Description = "Рыжеволосая сирота находит свой дом."
            },
            new Book
            {
                Id = 6, Title = "Ребекка", Author = "Дафна дю Морье",
                Genre = "Триллер", Year = 1938, Price = 810, IsAvailable = false,
                Pages = 448, ISBN = "978-5-17-090000-6",
                Description = "Загадочная история поместья Мэндерли."
            }
        };
    }
}
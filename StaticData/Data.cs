using SimbirSoft_Appl.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft_Appl.StaticData
{
    public static class Data
    {
        public static List<BookDto> Books { get; set; }
        public static List<HumanDto> People { get; set; }

        public static List<LibraryCard> LibraryCards { get; set; }

        static Data()
        {
            // 2.1.3 Пустой статичный список LibraryCard
            LibraryCards = new List<LibraryCard>();

            // 1.2.3 Статичный список людей
            People = new List<HumanDto>
            {
                new HumanDto{
                    Id = 0,
                    Name = "Иван",
                    Surname = "Иванов",
                    Patronymic = "Василич",
                    Birthday = new DateTime(1995, 12, 26),
                    IsAuthor = true
                },
                new HumanDto{
                    Id = 1,
                    Name = "Гурген",
                    Surname = "Вартаньян",
                    Patronymic = "Олегович",
                    Birthday = new DateTime(1994, 11, 27),
                    IsAuthor = false
                },
                new HumanDto{
                    Id = 2,
                    Name = "Сергей",
                    Surname = "Шмятько",
                    Patronymic = "Александрович",
                    Birthday = new DateTime(1993, 10, 28),
                    IsAuthor = true
                }
            };

            //1.2.3 Статичный список книг
            Books = new List<BookDto>
            {
                new BookDto
                {
                    Id = 0,
                    Title = "Созвездие морской медведицы",
                    Genre = "Экшон",
                    Author = People.Where(x => x.Id == 0).First(),
                    AuthorID = 0
                },
                new BookDto
                {
                    Id = 1,
                    Title = "Ночи под открытым небом",
                    Genre = "Историческое",
                    Author = People.Where(x => x.Id == 0).First(),
                    AuthorID = 0
                },
                new BookDto
                {
                    Id = 2,
                    Title = "C# для чайников или как получить оффер",
                    Genre = "Обучающая литература",
                    Author = People.Where(x => x.Id == 2).First(),
                    AuthorID = 2
                }
            };
        }
    }
}

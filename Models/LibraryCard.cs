using System;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft_Appl.Models
{
    /// <summary>
    /// 2.1.1 Человек взявший для прочтения книгу
    /// </summary>
    public class LibraryCard
    {
        public int Id { get; set; }

        [Required]
        public HumanDto Human{ get; set; }

        [Required]
        public BookDto Book{ get; set; }

        [Required]
        public DateTimeOffset PickedUp { get; set; }

        /// <summary>
        /// 2.1.5 Использование формата даты и времени
        /// </summary>
        /// <returns></returns>
        public string DateFormater()
        {
            return PickedUp.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
        }
    }
}

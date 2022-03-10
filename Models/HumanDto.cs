using System;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft_Appl.Models
{
    /// <summary>
    /// 1.2.1 Класс человека
    /// </summary>
    public class HumanDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Patronymic { get; set; }
        public bool IsAuthor { get; set; }

        public DateTime Birthday { get; set; }
    }
}

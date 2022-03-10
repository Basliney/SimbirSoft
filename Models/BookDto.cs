using System.ComponentModel.DataAnnotations;

namespace SimbirSoft_Appl.Models
{
    /// <summary>
    /// 1.2.2 Класс книги
    /// </summary>
    public class BookDto
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int AuthorID { get; set; }   //Ссылка на связную модель Human

        [Required]
        public virtual HumanDto Author{ get; set; }
    }
}

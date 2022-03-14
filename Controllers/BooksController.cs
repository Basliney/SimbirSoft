using Microsoft.AspNetCore.Mvc;
using SimbirSoft_Appl.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft_Appl.Controllers
{
    /// <summary>
    /// 1.4 Контроллер книг
    /// </summary>
    public class BooksController : Controller
    {
        /// <summary>
        /// 1.4.1 Метод Get, возвращающий:
        ///      .1 Список всех книг
        ///      .2 Список книг по определенному автору (AuthorId)
        /// </summary>
        /// <param name="sort">Параметр по которому возвращается .1 или .2</param>
        /// <param name="authorID">Идентификатор автора, по которому происходит поиск книг</param>
        /// <returns>Представление</returns>
        public ActionResult<List<BookDto>> Get(int sort, int authorID)
        {
            List<BookDto> allBooks;

            switch (sort)
            {
                case 0:
                    allBooks = DataLists.Books;
                    break;
                default:
                    allBooks = DataLists.Books.Where(x => x.AuthorID == authorID).ToList();
                    break;
            }
            if (allBooks.Count == 0)
            {
                return NoContent();
            }
            return allBooks;
        }

        /// <summary>
        /// 1.4.2 Метод Post для добавления новой книги
        /// </summary>
        /// <param name="book">книга</param>
        /// <param name="authorID">идентификатор автора</param>
        /// <returns>Представление</returns>
        public ActionResult Post(BookDto book, int authorID)
        {
            if (book == null)
            {
                return NoContent();
            }
            book.Id = MaxIndex();
            book.Author = DataLists.People.FirstOrDefault(x => x.Id == authorID);
            book.AuthorID = authorID;
            DataLists.Books.Add(book);
            return CreatedAtAction(nameof(Post), book);
        }

        /// <summary>
        /// 2.2.2 Сортировка книг
        /// </summary>
        /// <param name="numberOfSort">Номер сортировки</param>
        /// <returns></returns>
        public ActionResult<List<BookDto>> GetSorted(int numberOfSort)
        {
            switch (numberOfSort)
            {
                case 0:
                    return DataLists.Books.OrderBy(x => x.Title).ToList();
                case 1:
                    return DataLists.Books.OrderBy(x => x.Author.Surname).ToList();
                case 2:
                    return DataLists.Books.OrderBy(x => x.Genre).ToList();
                default:
                    return NoContent();
            }
        }

        private int MaxIndex()
        {
            int maxIndex = 0;

            foreach (BookDto book in DataLists.Books)
            {
                if (maxIndex < book.Id)
                {
                    maxIndex = book.Id;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// 1.4.3 Метод Delete для удаления книги
        /// </summary>
        /// <param name="id">идентификатор книги</param>
        /// <returns>Представление</returns>
        public ActionResult Delete(int id)
        {
            BookDto book = DataLists.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                DataLists.Books.Remove(book);
                return Ok();
            }
            return NotFound();
        }
    }
}

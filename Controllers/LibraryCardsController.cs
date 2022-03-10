using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimbirSoft_Appl.Models;
using SimbirSoft_Appl.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft_Appl.Controllers
{
    /// <summary>
    /// 2.1.2 Контроллер отвечающий за подбор книги читателем
    /// </summary>
    public class LibraryCardsController : Controller
    {
        public ActionResult<List<LibraryCard>> Get()
        {
            return Data.LibraryCards;
        }

        /// <summary>
        /// 2.1.4 Метод POST, отвечающий за получение книги человеком
        /// </summary>
        /// <returns></returns>
        public ActionResult Post(LibraryCard libraryCard)
        { 
            if (libraryCard == null)
            {
                return BadRequest();
            }
            libraryCard.Id = MaxIndex();
            libraryCard.PickedUp = DateTimeOffset.Now;
            Data.LibraryCards.Add(libraryCard);
            return Ok();
        }

        private int MaxIndex()
        {
            int maxIndex = 0;
            foreach(var libraryCard in Data.LibraryCards)
            {
                if (maxIndex < libraryCard.Id)
                {
                    maxIndex = libraryCard.Id;
                }
            }
            return maxIndex;
        }
    }
}

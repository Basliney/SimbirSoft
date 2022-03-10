using Microsoft.AspNetCore.Mvc;
using SimbirSoft_Appl.Models;
using SimbirSoft_Appl.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft_Appl.Controllers
{
    /// <summary>
    /// 1.3 Контроллер, отвечающий за человека
    /// </summary>
    public class HumansController : Controller
    {
        /// <summary>
        /// 1.3.1 метод Get возвращающий по параметру:
        /// 1 либо любое другое число: список всех людей;
        /// 2: список писателей;
        /// 3: список людей, в имени/фамилии/отчестве есть искомый текст;
        /// </summary>
        /// <param name="sort">номер отбора</param>
        /// <param name="find_text">искомый текст</param>
        /// <returns>Представление</returns>
        public ActionResult<List<HumanDto>> Get(int sort, string find_text)
        {
            List<HumanDto> allHumans = new List<HumanDto>();
            switch (sort)
            {
                default:
                    return Data.People;
                case 2:
                    allHumans = Data.People.Where(x => x.IsAuthor == true).ToList();
                    return allHumans;
                case 3:
                    if (find_text != null)
                    {
                        allHumans = Data.People.Where(x => x.Name.ToLower().Contains(find_text.ToLower())
                            || x.Surname.ToLower().Contains(find_text.ToLower()) || x.Patronymic.ToLower().Contains(find_text.ToLower())).ToList();
                    }
                    return allHumans;
            }
        }

        /// <summary>
        /// 1.3.2 метод POST добавляющий человека
        /// </summary>
        /// <param name="human">Человек для добавления</param>
        /// <returns>Представление</returns>
        public ActionResult Post(HumanDto human)
        {
            /*
             *  Ссылка для добавления человека
             *  https://localhost:44354/Humans/Post?Name=%D0%96%D0%B0%D0%BA&Surname=Suhfer&Patronymic=asd
             *  Ссылка для вызова ошибки валидации
             *  https://localhost:44354/Humans/Post?Name=%D0%96%D0%B0%D0%BA&Surname=Suhfer&Patronymic=
            */
            if (human == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            human.Id = MaxIndex();
            Data.People.Add(human);
            return CreatedAtAction(nameof(Post), human);
        }

        private int MaxIndex()
        {
            int maxIndex = 0;

            foreach (HumanDto human in Data.People)
            {
                if (maxIndex < human.Id)
                {
                    maxIndex = human.Id;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// 1.3.3 Метод удаления человека
        /// </summary>
        /// <param name="id">id человека, которого надо удалить</param>
        /// <returns>Представление</returns>
        public IActionResult Delete(int id)
        {
            HumanDto human;
            human = Data.People.FirstOrDefault(x => x.Id == id);
            if (human == null)
            {
                return BadRequest();
            }
            Data.People.Remove(human);
            return Ok();
        }
    }
}

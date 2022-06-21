using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrarybers
{
    public class Thematicmenu: Menu // тематическое меню
    {
      public string Фишкаблюда { get; set; }
      public string Деньподачиблюда { get; set; }


        public Thematicmenu()
        {
        }

        public override string ToString()
        {
            return $"Наименование:{Наименование} Цена:{Цена} Граммовка:{Граммовка} Фишкаблюда:{Фишкаблюда} Деньподачиблюда:{Деньподачиблюда}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrarybers
{
    public class Drinks : Menu // напитки
    {
        public string Состав { get; set; }
        public string Цвет { get; set; }
        public string Категория { get; set; }

        public Drinks()
        {
        }

        public override string ToString()
        {
            return $"Наименование:{Наименование} Цена:{Цена} Граммовка:{Граммовка} Состав:{Состав} Цвет:{Цвет} Категория:{Категория}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeLibrarybers
{
    public class Dishes: Menu  // Блюда
    {
        public string Состав { get; set; }
        public string Размер { get; set; }
        public string Тип { get; set; }

        public Dishes()
        {
        }

        public override string ToString()
        {
            return $"Наименование:{Наименование} Цена:{Цена} Граммовка:{Граммовка} Состав:{Состав} Размер:{Размер} Тип:{Тип}";
        }
    }
}

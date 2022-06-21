using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrarybers
{
    public class Cuisine
    {
        public int Количествоповаров { get; set; }
        public DateTime Времяприготовленияблюда { get; set; }

        public Cuisine()
        {
        }
        public override string ToString()
        {
            return $"Количествоповаров:{Количествоповаров} Времяприготовленияблюда:{Времяприготовленияблюда}";
        }
    }
}

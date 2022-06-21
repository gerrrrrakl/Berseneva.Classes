using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLibrarybers
{
    public class Customer
    {
        public int Электроннаяпочта { get; set; }
        public int Номертелефона { get; set; }

        public Customer()
        {
        }


        public override string ToString()
        {
            return $"Электроннаяпочта:{Электроннаяпочта} Номертелефона:{Номертелефона}";
        }
    }
}

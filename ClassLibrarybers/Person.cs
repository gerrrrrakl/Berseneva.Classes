using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeLibrarybers;


namespace CafeLibrarybers
{
    public class Person : IPerson1
    {
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string ID = new(Guid.NewGuid().ToString("n").Substring(0, 10));



        public string CreateИмя()
        {
            while (true)
            {
                Console.Write("Введите ваше Имя, не менее 2-х букв: ");
                var pass = Console.ReadLine();
                if (pass.Length < 2)
                {
                    Console.Write("Слишком мало букв, попробуйте ещё раз, нажмите 'Enter'");
                    Console.ReadLine();
                    Console.Clear();
                }
                else return pass;
            }
        }

        public Person()
        {
        }


        public override string ToString()
        {
            return $"Имя:{Имя} Фамилия:{Фамилия} ID:{ID}";
        }
    }
}

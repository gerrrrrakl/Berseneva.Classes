using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeLibrarybers;


namespace CafeLibrarybers
{
    public class Waiter:Person 
    { 
        public string Количествостоликов { get; set; }
        public string Должность { get; set; }
        public void Event()
        {    // создаем объект дел
            EventArgs1 dolist = new EventArgs1();

            // Добавляем обработчики событий
            dolist.OnAddToDo += ShowMessage;
            // добавляем дела
            dolist.AddDo("  принять заказ");
            dolist.AddDo("  передать заказ кухне");
        }
        // имплементация события
        public static void ShowMessage(String text)
        {
            Console.WriteLine(text);
        }
    }
}

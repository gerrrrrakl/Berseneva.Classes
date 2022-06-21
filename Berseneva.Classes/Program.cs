using System;
using System.Text.Encodings;
using System.Text.Encodings.Web;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CafeLibrarybers;

namespace Berseneva.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cafe1 = new Cafe();
            Console.CancelKeyPress += Cafe.Console_CancelKeyPress;
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В КАФЕ BT21.CAFE");
            Console.WriteLine();
            Console.WriteLine("Выберите Пользователя 1-покупатель 2- официант ");// выбор пользователя
            var type = Console.ReadLine();

            switch (type)
            {
                case "1":
                    OrderCustomer();// покупатель 
                    break;

                case "2":
                    OrderWaiter(); // официант
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

             

            static void OrderCustomer()
            {
                var cafe = new Cafe();
                var person = new Person();
                Customer customer = new Customer();
                person.CreateИмя();
                Console.ReadKey();
                Console.WriteLine("Введите номер столика: ");
                Console.ReadLine();
                Console.WriteLine("Выберите товар,который хотите добавить в заказ, и напишите его наименование");
                cafe.Display();

            }

            static void OrderWaiter()
            {
                var person2 = new Person();
                var cafe2 = new Cafe();
                Waiter waiter = new Waiter();
                waiter.Event(); 
                        

            }

        }
    }

}
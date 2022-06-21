using System.Text;

namespace CafeLibrarybers
{
    public class Cafe
    {
        public static double Summ;
        public double Summ2;
        public static List<Menu> basketlist = new List<Menu>();



        public void Display() // вывод единиц меню 
        {


            Console.WriteLine("Напитки");

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding(1251);

            var path = @"..\..\..\Drinks.csv";
            var lines = File.ReadAllLines(path, encoding);
            var Drinks1 = new List<Drinks>();
            var Blist = new List<Menu>();
            for (var i = 0; i < lines.Length - 1; i++)
            {
                var splits = lines[i + 1].Split(';');
                var drink = new Drinks();
                drink.Наименование = Convert.ToString(splits[0]);
                drink.Цена = Convert.ToDouble(splits[1]);
                drink.Граммовка = Convert.ToDouble(splits[2]);
                drink.Состав = Convert.ToString(splits[3]);
                drink.Цвет = Convert.ToString(splits[4]);
                drink.Категория = Convert.ToString(splits[5]);
                Drinks1.Add(drink);
                Blist.Add(drink);
                Console.WriteLine(drink);
            }
            Console.WriteLine("Блюда");


            var path2 = @"..\..\..\Dishes.csv";
            var lines2 = File.ReadAllLines(path2, encoding);
            var Dishes1 = new List<Dishes>();
            for (var i = 0; i < lines2.Length - 1; i++)
            {
                var splits = lines2[i + 1].Split(';');
                var dishes2 = new Dishes();
                dishes2.Наименование = Convert.ToString(splits[0]);
                dishes2.Цена = Convert.ToDouble(splits[1]);
                dishes2.Граммовка = Convert.ToDouble(splits[2]);
                dishes2.Состав = Convert.ToString(splits[3]);
                dishes2.Размер = Convert.ToString(splits[4]);
                dishes2.Тип = Convert.ToString(splits[5]);
                Dishes1.Add(dishes2);
                Blist.Add(dishes2);
                Console.WriteLine(dishes2);

            }

            Console.WriteLine("Тематическое меню");


            var path3 = @"..\..\..\Thematicmenu.csv";
            var lines3 = File.ReadAllLines(path3, encoding);
            var Them1 = new List<Thematicmenu>();
            for (var i = 0; i < lines3.Length - 1; i++)
            {
                var splits = lines3[i + 1].Split(';');
                var them1 = new Thematicmenu();

                them1.Наименование = Convert.ToString(splits[0]);
                them1.Цена = Convert.ToDouble(splits[1]);
                them1.Граммовка = Convert.ToDouble(splits[2]);
                them1.Фишкаблюда = Convert.ToString(splits[3]);
                them1.Деньподачиблюда = Convert.ToString(splits[4]);
                Them1.Add(them1);
                Blist.Add(them1);
                Console.WriteLine(them1);
                //Prname(Blist);
            }
            Prname(Blist);
        }

        static void Prname(List<Menu> prod)// выбор товара по наименованию+сумма заказа 
        {
            int type = 1;
            while (type == 1)
            {

                int index = 0;
                while (true)
                {
                    Console.Write("Введите Наименование товара: ");

                    var un = Convert.ToString(Console.ReadLine());


                    if (!prod.Exists(x => x.Наименование == un))
                    {
                        Console.Write("Такого наименование нет , попробуйте ещё раз, нажмите 'Enter'");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        index = prod.FindIndex(x => x.Наименование == un);
                        basketlist.Add(prod[index]);
                        Console.WriteLine("1-Продолжить покупку; 2- Корзина наполнена");
                        type = Convert.ToInt32(Console.ReadLine());
                        //Cuisine cuisine = new Cuisine();
                        Summ = basketlist.Sum(x => x.Цена);
                        if (type == 2)
                        {
                            //Cuisine cuisine = new Cuisine();
                            var sum = basketlist.Sum(x => x.Цена);
                            Console.WriteLine("Сумма заказа: " + sum);
                            Console.WriteLine("Спасибо за заказ!");
                            Console.WriteLine("Ваш заказ будет готов через 30 минут.");
                            return;
                        }

                    }
                }
            }
            return;
        }


        public static void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)

        {
            Console.WriteLine("Программа прервана, данные сохранены в файл");
            var result = "SaveOrder.txt";
            StreamWriter streamWriter = new StreamWriter(result);
            foreach (Menu pr in basketlist)
            {
                Console.WriteLine(pr);
                streamWriter.WriteLine(pr);
            }
            streamWriter.WriteLine(Summ);
            streamWriter.Close();
            e.Cancel = true;

        }
        private static void Account_Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}

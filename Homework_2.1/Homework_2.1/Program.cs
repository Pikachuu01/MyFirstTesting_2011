using System;

namespace Homework_2._1
{
    class Program
    {
        // Задание №4 (Чек)
        static void Main(string[] args)
        {
            string NameShop = "Пятерочка";
            string Site_FNS = "www.nalog.ru";
            string NNN = "7842005813";
            string Admin_num = "#8343";
            string Shift = "2 смена";
            DateTime dt = DateTime.Now;
            decimal milk = Convert.ToDecimal(44.99);
            decimal bread = Convert.ToDecimal(35.55);
            decimal meat = Convert.ToDecimal(169.99);
            decimal sum = milk + bread + meat;
            decimal money = Convert.ToDecimal(260);
            decimal delivery_money = money - sum;
            decimal NDS_proc = Convert.ToDecimal(0.13);
            decimal NDS = sum * NDS_proc;

            Console.WriteLine($"----------{NameShop}-----------");
            Console.WriteLine("------Спасибо за покупку!------");
            Console.WriteLine("-------------------------------");
           Console.WriteLine($"___Ситс. Админ____________{Admin_num}"); ; ;
           Console.WriteLine($"___ННН_______________{NNN}");
           Console.WriteLine($"___Сайт ФНС________{Site_FNS}");
           Console.WriteLine($"___Смена________________{Shift}");
           Console.WriteLine($"___Дата______{dt}");
            Console.WriteLine("-------------------------------");
           Console.WriteLine($"___1)Молоко___________{milk} руб.");
           Console.WriteLine($"___2)Хлеб_____________{bread} руб.");
           Console.WriteLine($"___3)Мясо____________{meat} руб.");
            Console.WriteLine("-------------------------------");
           Console.WriteLine($"___ИТОГ______________{sum} руб.");
           Console.WriteLine($"___Наличными____________{money} руб.");
           Console.WriteLine($"___Сдача____________{delivery_money} руб.");
           Console.WriteLine($"___НДС__________________{NDS}"); ;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("------Спасибо за покупку!------");
            Console.WriteLine("------Спасибо за покупку!------");
        }
    }
}

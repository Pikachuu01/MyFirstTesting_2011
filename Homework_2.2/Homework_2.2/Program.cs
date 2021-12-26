using System;

namespace Homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание №5 (Неправильная погода)

            Console.WriteLine("Введите месяц: 1-12");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите температуру");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (month == 12 || month == 1 || month == 2)
            {
                if (temp > 0)
                {
                    Console.WriteLine("Дождливая зима");
                }
                else
                {
                    Console.WriteLine("Чудесная погода");
                }
            }
            if (month == 3 || month == 4 || month == 5)
            {
                if (temp > 0)
                {
                    Console.WriteLine("Теплая весна");
                }
                else
                {
                    Console.WriteLine("Снег с дождем...фу");
                }
            }
            if (month == 6 || month == 7 || month == 8)
            {
                if (temp > 20)
                {
                    Console.WriteLine("Теплое лето");
                }
                else
                {
                    Console.WriteLine("Холодное лето");
                }
            }
            if (month == 9 || month == 10 || month == 11)
            {
                if (temp < 0)
                {
                    Console.WriteLine("Снег с дождем...фу");
                }
                else
                {
                    Console.WriteLine("Теплая весна");
                }
            }
        }
    }
}

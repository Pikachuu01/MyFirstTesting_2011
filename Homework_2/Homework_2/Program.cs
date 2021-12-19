using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1 (среднесуточная температура)

            Console.WriteLine("Введите максимальную температуру");
            int MaxTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минимальную температуру");
            int MinTemp = Convert.ToInt32(Console.ReadLine());

            int S = (MaxTemp + MinTemp) / 2;
            Console.WriteLine($"среднесуточная температура {S}");



            // Задание №2 (Порядковый номер месяца)

            Console.WriteLine("Введите Порядковый номер месяца");
            int N = Convert.ToInt32(Console.ReadLine());

            switch (N)
            {
                case 1:
                    Console.WriteLine("Это январь");
                    break;
                case 2:
                    Console.WriteLine("Это февраль");
                    break;
                case 3:
                    Console.WriteLine("Это март");
                    break;
                case 4:
                    Console.WriteLine("Это апрель");
                    break;
                case 5:
                    Console.WriteLine("Это май");
                    break;
                case 6:
                    Console.WriteLine("Это июнь");
                    break;
                case 7:
                    Console.WriteLine("Это июль");
                    break;
                case 8:
                    Console.WriteLine("Это август");
                    break;
                case 9:
                    Console.WriteLine("Это сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Это октябрь");
                    break;
                case 11:
                    Console.WriteLine("Это ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Это декабрь");
                    break;
            }

            // Задание №3 (четное число)
            Console.WriteLine("Введите число");
            double num = Convert.ToDouble(Console.ReadLine());
            bool chet = num % 2 == 0;
            if (chet)
            {
                Console.WriteLine("Это четное число");
            }

            else
            {
                Console.WriteLine("Это нечетное число");
            }

        }
    }
}

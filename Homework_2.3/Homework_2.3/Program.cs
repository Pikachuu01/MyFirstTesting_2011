using System;

namespace Homework_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №6 (План работы)
            Console.WriteLine("Введите день недели 1-7");
            int N = Convert.ToInt32(Console.ReadLine());
            switch (N)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Сегодня работает первый отдел");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Сегодня работает второй отдел");
                    break;
                case 7:
                    Console.WriteLine("Сегодня выходной");
                    break;
            }
        }
    }
}

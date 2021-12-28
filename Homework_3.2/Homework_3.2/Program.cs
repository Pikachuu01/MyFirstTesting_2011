using System;

namespace Homework_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //«Телефонный справочник»

            string[,] Arr =
            {
                {
                "Иванов",
                "Петров",
                "Сидоров",
                "Филиппова",
                "Егоров"
                },
                {
                "o@outlook.com",
                "hr6zdl@yandex.ru",
                "kaft93x@outlook.com",
                "dcu@yandex.ru",
                "19dn@outlook.com"
                }
            };
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            bool isFound = false;

            for (int i = 0; i < Arr.Rank; i++)
            {
                for (int j = 0; j < Arr.Rank; j++)
                {
                    if (Arr[0 , j] == lastName && !isFound) 
                    {
                        Console.WriteLine($"человек с фамилией {lastName} имеет почту: {Arr[1, j]}");
                        isFound = true;
                        break;
                    }


                }
                Console.WriteLine();
            }
            if (!isFound)
            {
                Console.WriteLine("Такого человека нет в списке :(");
            }

        }
    }
}

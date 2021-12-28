using System;

namespace Homework_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну столбца ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длинну строки ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] Arr =new int[n, m];

            Random rn = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Arr[i, j] = rn.Next(1,15);
                    Console.Write("{0}\t", Arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("элементы двумерного массива по диагонали:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j) 
                    Console.WriteLine(Arr[i, j]+ " ");
                }
            }
        }
    }
}

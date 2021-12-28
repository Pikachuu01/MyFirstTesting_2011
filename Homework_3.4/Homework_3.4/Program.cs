using System;

namespace Homework_3._4
{
    class Program
    {
        static void Main(string[] args)
            // Морской бой
        {
            int[,] Arr = new int[10, 10];
            Random rn = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Arr[i, j] = rn.Next(1, 3);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    switch (Arr[i, j])
                    {
                        case 1:
                            Console.Write("{0}", "O");
                            break;
                        case 2:
                            Console.Write("{0}", "X");
                            break;

                    }

                }

                Console.WriteLine();
            }
        }
    }
}

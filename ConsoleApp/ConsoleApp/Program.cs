using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k=0;
            int[,] C = new int[7, 7]; // Массив C
            Console.WriteLine("Массив C: ");
            Random rnd = new Random();
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    C[i, j] = rnd.Next(-50, 50); // Заполнение случайными значениями
                    Console.Write($"C[{i},{j}] = {C[i, j]}\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Побочная диагональ: ");
            for (j = 7 - 1, i = 0; j >= 0; i++, j--) // Вывод побочной диагонали
            {
                if (C[i, j] < 0) // Условие, считающее кол-во отрицательных чисел
                    k = k + 1;
                Console.WriteLine(C[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine("Кол-во отрицательных чисел побочной диагонали: ");
            Console.WriteLine(k);

        }
    }
}
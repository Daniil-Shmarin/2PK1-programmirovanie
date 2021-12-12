using System;

namespace PZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mas = new double[20];
            double max = -15;
            Random rnd = new Random();
            for (int i = 0; i<20 ; i++)
            {
                mas[i] = rnd.Next(-15, 15);
                Console.Write(@$"{mas [i]} ");
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine();
            Console.Write("Максимальное число равно: ");
            Console.WriteLine(max);
            Console.Write("Числа, которые больше по модулю: ");
            for (int i = 0; i<20; i++)
            {
                if (Math.Abs(mas[i]) > max)
                    Console.Write(@$"{mas[i]} ");
            }
        }
    }
}

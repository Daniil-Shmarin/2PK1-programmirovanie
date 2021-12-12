using System;

namespace PZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            for (double i = -50; i <= 0; i+=5)
                Console.WriteLine(i);
            Console.WriteLine("");
            //Задание 2
            for (int i = 0; i < 7; i ++)
            {
                Console.Write((char)(i + 'л'));
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //Задание 3
            for (double i = 1; i < 11; i ++)
                Console.WriteLine("####");

            Console.WriteLine("");
            //Задание 4
            for (double i = 0; i <= 100; i++)
                if (i % 14 == 0)
                    Console.WriteLine(i);
            Console.WriteLine("");
            //Задание 5
            double j = 45;
            for (double i = 0; (i-j) !<= 17; i++)
            {
                Console.WriteLine("{0} {1}", i, j);
                j--;
            }
        }
    }
}

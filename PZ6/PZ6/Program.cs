using System;

namespace PZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.8м/с в квадрат, каждые 0.5  v=gt
            double t = Double.Parse(Console.ReadLine());
            double i=0;
            i = t;
            while (i >0)
            {
                Console.WriteLine(t * 4.9);
                t = t + 0.5;
                i = i - 0.5;
            }

        }

    }
}

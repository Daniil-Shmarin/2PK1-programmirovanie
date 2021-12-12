using System;

namespace PZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите d: ");
            double d = Double.Parse(Console.ReadLine());
            double p = 0;
            double q = 0;
            if (d > 0)
            {
                p = 17 * c - d;
            }
            else if (d <= 0)
            {
                p = Math.Log(2d + 50);
            }
            Console.WriteLine(p);
            if (p <= 11)
            {
                q = Math.Tan(c + Math.Pow(p, 2));
            }
            else if (p > 11) ;
            {
                q = (p - c * d) / (Math.Pow(p, 2) + c + d);
            }
            Console.WriteLine(q);
            double r = 0;
            Console.Write(r = Math.Pow(p + q, 3) - 11);

        }
    }
}

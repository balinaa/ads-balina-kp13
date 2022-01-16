using System;

namespace lab1.ex2.asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write n: ");
            int n = int.Parse(Console.ReadLine());
            int k, y;
            for (int i = 1; i <= n; i++)
            {
                y = i;
                k = 1;
                while (y != 0)
                {
                    y = y / 10;
                    k = k * 10;
                }
                if (i * (i - 1) % k == 0)
                    Console.WriteLine(i);
            }
        }
    }
}

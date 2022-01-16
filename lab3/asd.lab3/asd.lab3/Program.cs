using System;

namespace asd.lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            int y = 0;
            Random rand = new Random();
            Console.WriteLine("несортированный массив: ");
            for (int i = 0; i < n; i++)
            {
                x[i] = rand.Next(n);
                y = x[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (x[i] == x[j])
                        {
                            x[i] = rand.Next(n);
                            j = 0;
                            y = x[i];
                        }

                        y = x[i];
                    }
                }
                Console.WriteLine(x[i]);
            }
            int a = x[0];
            Console.WriteLine("x[0] = " + x[0]);
            bool isSorted = false;
            while (!isSorted)
            {
                int temp = 0;
                isSorted = true;
                for (int i = 0; i < n - 1; i = i + 2)
                {
                    if (x[i] > x[i + 1])
                    {
                        temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        isSorted = false;
                    }
                }

                for (int i = 1; i < n - 1; i = i + 2)
                {
                    if (x[i] > x[i + 1])
                    {
                        temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        isSorted = false;
                    }
                }
               
            }
            isSorted = false;
            while (!isSorted)
            {
                int temp = 0;
                isSorted = true;
                for (int i = 0; i < a-1; i = i + 2)
                {
                    if (x[i] < x[i + 1])
                    {
                        temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        isSorted = false;
                    }
                }

                for (int i = 1; i < a-1; i = i + 2)
                {
                    if (x[i] < x[i + 1])
                    {
                        temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        isSorted = false;
                    }
                }

            }
            

            Console.WriteLine("сортированный массив: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}

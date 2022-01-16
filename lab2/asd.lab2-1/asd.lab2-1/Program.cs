using System;
using static System.Console;


namespace asd.lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Write("розмiрнiсть матрицi: ");
            N = Convert.ToInt32(ReadLine());
            if (N < 0)
            {
                Write("Введiть значення N > 0 : ");
                N = Convert.ToInt32(ReadLine());
            }
            int T, K;
            Write("Введiть данi для генератора псевдовипадкових чисел  T=: ");
            T = Convert.ToInt32(ReadLine());
            Write("Введiть данi для генератора псевдовипадкових чисел  K=: ");
            K = Convert.ToInt32(ReadLine());

            int[,] arr = new int[N, N];

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                arr[i, 0] = rnd.Next(T, K);
                Write(arr[i, 0].ToString() + "\t");

                for (int j = 1; j < N; j++)
                {
                    arr[i, j] = rnd.Next(T, K);
                    Write(arr[i, j].ToString() + "\t");
                }
                WriteLine();
            }
            int min = K;
            if (N <= 1)
            {
                WriteLine("Мiнiмальний елемент над головною дiагоналлю не iснує");

            }
            else
            {
                min = arr[0, 1];
            }
            int x, y, a, w = 0, v = 0;
            Write("\nПослiдовнiсть обходу над головною дiагоналлю:: ");

            for (int k = 0, g = 0; k < (N - 1) / 3.0; k++, g = g + 2)
            {


                for (x = k, y = g + 1; y < N - k; y++)
                {
                    a = arr[x, y];
                    Write("{0} [{1},{2}];  ", a, x, y);
                    if (arr[x, y] < min)

                    {
                        min = arr[x, y];
                        w = x; v = y;
                    }

                }
                for (x = k + 1, y = N - (k + 1); x < N - (g + 1); x++)
                {
                    a = arr[x, y];
                    Write("{0} [{1},{2}];  ", a, x, y);
                    if (arr[x, y] < min)

                    {
                        min = arr[x, y];
                        w = x; v = y;
                    }
                }
                for (x = N - (g + 3), y = N - (k + 2); x > k && y > g + 1; y = y - 1, x = x - 1)
                {

                    a = arr[x, y];
                    Write("{0} [{1},{2}];  ", a, x, y);

                    if (arr[x, y] < min)

                    {
                        min = arr[x, y];
                        w = x; v = y;

                    }
                }
            }



            WriteLine("Мiнiмальний елемент над головною дiагоналлю: = {0} [{1},{2}] ", min, w, v);
            int dsum = 0;
            int halfsum;


            Write("\nПослiдовнiсть обходу , яка включає головну дiагональ та елементи пiд головною дiагоналлю: ");


            for (x = 0, y = 0; y < N && x < N; y++, x++)
            {
                a = arr[x, y];
                Write("{0} [{1},{2}];  ", a, x, y);

                dsum = dsum + a;

            }


            halfsum = dsum / N;
            int more = halfsum;
            WriteLine("\nНапiв сума елементiв дiагоналi: " + halfsum);

            for (int k = 0, g = 0; k <= (N - 1) / 3; k++, g = g + 2)
            {


                for (x = N - (k + 1), y = N - (g + 2); y >= k; y--)
                {
                    a = arr[x, y];
                    Write("{0} [{1},{2}];  ", a, x, y);
                    if (arr[x, y] > more)

                        WriteLine("елемент, що бiльший за напiвсуму елементiв дiагоналi: = {0} [{1},{2}] ", arr[x, y], x, y);
                }

                for (x = N - (k + 2), y = k; x >= g + 1; x = x - 1)
                {

                    a = arr[x, y];
                    Write("{0} [{1},{2}];  ", a, x, y);

                    if (arr[x, y] > more)

                        WriteLine("елемент, що бiльший за напiв суму елементiв дiагоналi: = {0} [{1},{2}] ", arr[x, y], x, y);
                }
                for (x = g + 2, y = k + 1; y < N - (g + 1) && x < N - (k + 1); y++, x++)
                {
                    a = arr[x, y];
                    Write("{0} [{1},{2}];  ", a, x, y);
                    if (arr[x, y] > more)

                        WriteLine("елемент, що бiльший за напiв суму елементiв дiагоналi: = {0} [{1},{2}] ", arr[x, y], x, y);

                }



            }
        }
    }
}
using System;

namespace lab5asd
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1) Згенерувати матрицю " +
                     "2)Контрольний приклад");
            int ch = int.Parse(Console.ReadLine());
            int m = 100, n = 100, s = 0;
            Random rand = new Random();
            int[,] arr = new int[m, n];
            if (ch == 1)
            {
                Console.WriteLine("write m:");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("write n:");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        arr[i, j] = rand.Next(1, 100);

                    }
                }
            }
            else if (ch == 2)
            {
                m = 4; n = 3;
                arr = new int[,] { { 27, 29, 65 }, { 12, 94, 81 }, { 5, 17, 43 }, { 76, 38, 2 } };
            }
            
            Console.WriteLine("matrix:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    int value = arr[i, j];
                    Console.Write(value + " ");
                    if (i % 2 == 1 & j % 2 == 0)
                        s++;
                }
                Console.WriteLine();
            }
            int[] a1 = new int[s];
            int[] a2 = new int[(m * n) - s];
            int ct1 = 0, ct2 = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 1 & j % 2 == 0)
                    {
                        a1[ct1] = arr[i, j];
                        ct1++;

                    }
                    else
                    {

                        a2[ct2] = arr[i, j];
                        ct2++;
                    }

                }
            }
            int pivot1 = (a1.Length + 1) / 2;
            Quick_Sort(a1, 0, a1.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Парні стовпці, непарні рядки: ");
            foreach (var item in a1)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            int pivot2 = (a2.Length + 1) / 2;
            Quick_Sort(a2, 0, a2.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Решта елементів : ");
            foreach (var item in a2)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();


        }
    }
}

using System;

namespace lab1.ex1.asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write x: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("write y: ");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("write z: ");
            double z = int.Parse(Console.ReadLine());

            double a = (y-Math.Sqrt(Math.Abs(Math.Pow(x,3))))/ (Math.Sqrt(Math.Pow(x,3)+5*Math.Pow(y,(-z))+Math.Pow(z,2)));
            double b = Math.Sin(Math.Pow(a, (-x))) + y;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}

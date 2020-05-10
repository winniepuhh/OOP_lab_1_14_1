using System;

namespace OOP_lab_1_14_1
{
    public class Program
    {
        public static double Sa(double a, double b)
        {
            return (a + b) / 2;
        }

        public static double Sg(double a, double b)
        {
            return Math.Sqrt(a * b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть друге число");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nsa = {0}, sg = {1}", Sa(a, b), Sg(a, b));
        }
    }
}

using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace GenericsDemoNumberComparision
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics Demo Program");

            Console.WriteLine("Enter three Integers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("max of three numbers is :" + getMaximum(a, b, c));

        }
        private static int getMaximum(int a, int b, int c)
        {
            return a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0 ? a : b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0 ? b : c;

        }
    }
}


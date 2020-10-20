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
            int firstInt = Convert.ToInt32(Console.ReadLine());
            int secondInt= Convert.ToInt32(Console.ReadLine());
            int thirdInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("max of three numbers is :" + getMaximum(firstInt,secondInt,thirdInt));

            Console.WriteLine("Enter three FLoat values");
            double firstDouble = Convert.ToDouble(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            double thirdDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("max of three numbers is :" + getMaximum(firstDouble,secondDouble,thirdDouble));



        }
        private static int getMaximum(int a, int b, int c)
        {
            return a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0 ? a : b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0 ? b : c;

        }
        private static double getMaximum(double a, double b, double c)
        {
            return a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0 ? a : b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0 ? b : c;

        }
    }
}


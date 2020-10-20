using System.Collections.Generic;
using System;

namespace GenericsDemoNumberComparision
{
   public class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics Demo Program");

            Console.WriteLine("Enter three Integers");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            int secondInt= Convert.ToInt32(Console.ReadLine());
            int thirdInt = Convert.ToInt32(Console.ReadLine());


            maxGeneric<int> intObj = new maxGeneric<int>(firstInt,secondInt,thirdInt);

            Console.WriteLine("max of three numbers is : " + intObj.getMaximum());

            Console.WriteLine("Enter three FLoat values");
            double firstDouble = Convert.ToDouble(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            double thirdDouble = Convert.ToDouble(Console.ReadLine());

            maxGeneric<double> doubleObj = new maxGeneric<double>(firstDouble, secondDouble, thirdDouble);
            Console.WriteLine("max of three numbers is : " + doubleObj.getMaximum());


            Console.WriteLine("Enter three strings");
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string thirdString = Console.ReadLine();
            maxGeneric<string> stringObj = new maxGeneric<string>(firstString, secondString, thirdString);
            Console.WriteLine("Max of three strings is : " + stringObj.getMaximum());


        }

        public class maxGeneric<myData> where myData : IComparable
        {
           public  myData a,b,c;
            public maxGeneric(myData a, myData b, myData c)
                {
                this.a=a;
                this.b=b;
                this.c=c;
                }
            public  myData getMaximum()
            {
                return a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0 ? a : b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0 ? b : c;

            }
        }
       
    }
}


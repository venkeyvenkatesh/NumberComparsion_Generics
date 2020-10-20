using System.Collections.Generic;
using System;

namespace GenericsDemoNumberComparision
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics Demo Program");


            int[] intArr = { 10, 200, 30, 60, 598 };


            maxGeneric<int> intObj = new maxGeneric<int>(intArr);

            Console.WriteLine("max of given integer numbers is : " + intObj.getMaximum());


            double[] doubleArr = { 2.4, 6.8, 9.6, 8.9, 7.4 };
            maxGeneric<double> doubleObj = new maxGeneric<double>(doubleArr);
            Console.WriteLine("max of three numbers is : " + doubleObj.getMaximum());


            string[] stringArr = { "123", "587", "352", "489", "156" };
            maxGeneric<string> stringObj = new maxGeneric<string>(stringArr);
            Console.WriteLine("Max of three strings is : " + stringObj.getMaximum());


        }

        public class maxGeneric<myData> where myData : IComparable
        {
            public myData[] arr;
            public maxGeneric(myData[] arr)
            {
                this.arr = arr;
            }
            public myData getMaximum()
            {

              Array.Sort(this.arr);

                return this.arr[this.arr.Length - 1];
            }
        }

    }
}


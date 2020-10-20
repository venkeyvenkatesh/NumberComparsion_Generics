using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace GenericsDemoNumberComparision
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics Demo Program");


            int[] intArr = { 10, 200, 30, 60, 598 };


            maxGeneric<int> intObj = new maxGeneric<int>(intArr);

           intObj.getMaximum();


            double[] doubleArr = { 2.4, 6.8, 9.6, 8.9, 7.4 };
            maxGeneric<double> doubleObj = new maxGeneric<double>(doubleArr);
            doubleObj.getMaximum();


            string[] stringArr = { "123", "587", "352", "489", "156" };
            maxGeneric<string> stringObj = new maxGeneric<string>(stringArr);
            stringObj.getMaximum();


        }

        public class maxGeneric<myData> where myData : IComparable
        {
            public myData[] arr;
            public maxGeneric(myData[] arr)
            {
                this.arr = arr;
            }
            public void getMaximum()
            {

              Array.Sort(this.arr);
                printMax(this.arr[this.arr.Length - 1]);
               
            }
            public void printMax(myData max)
            {

                Console.WriteLine("Max value among  is "+max);
            }
        }

    }
}


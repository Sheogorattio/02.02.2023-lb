using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02._2023_lb
{
    internal class Program
    {
        static int nOddCheck(int[] arr)
        {
            int res = 0;
            foreach(var i in arr)
            {
                if (i % 2 == 1) res++;
            }
            return res;
        }

        static int nEvenCheck(int[] arr)
        {
            int res = 0;
            foreach(var i in arr)
            {
                if(i % 2 == 0) res++;
            }
            return res;
        }

        static int nCheckRedundance(int[] arr)
        {
            int repeats = 0, res=0; 
            foreach(var i in arr)
            {
                foreach(var j in arr)
                {
                    if(i==j) repeats++;
                }
                if(repeats ==1) res++;
                repeats = 0;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            #region task 1
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(0, 100);
                    Console.Write($"{arr[i]}  ");
                }
                Console.WriteLine($"\nOdd values number:\t{nOddCheck(arr)}\nEven values number:\t{nEvenCheck(arr)}\nOriginal values number:\t{nCheckRedundance(arr)}");
            }
            #endregion
            #region task 2
            {
                Console.WriteLine("Enter number");
                int num = Convert.ToInt32(Console.ReadLine()), res=0;
                foreach(var i in arr)
                {
                    if (i < num) res++;
                }
                Console.WriteLine($"Number of values less than {num}:\t{res}");
            }
            #endregion
            #region task 3
            {
                Console.WriteLine("Enter number sequnce(3 numbers)");
                int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine()), num3 = Convert.ToInt32(Console.ReadLine()),res=0;
                for(int i =0; i < arr.Length - 2; i++)
                {
                    if (arr[i] == num1 && arr[i + 1] == num2 && arr[i + 2] == num3) res++;
                }
                Console.WriteLine($"Sequence repeats:\t{res}");
            }
            #endregion
            Console.ReadKey(); 
        }
    }
}
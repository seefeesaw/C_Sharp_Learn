using System;

namespace MethodOverloading
{
    class Program
    {
        //mETHODS CAN BE OVERLOADED BASED ON NUMBER OF
        //PARAMETERS AND TYPE OF PARAMETERS and Kinds of parameters
        //its not possible to overload a function based on return type
        //and params key word or modifier
        static void Main(string[] args)
        {
            Add(5, 3);
        }
        public static void Add(int FN,int SN)
        {
            Console.WriteLine("Sum = {0}",FN + SN);
        }
        public static void Add(int FN, ref int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN,int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }
        public static void Add(int FN, int SN, int TN,int FORTHNUMBER)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN + FORTHNUMBER);
        }

    }
}

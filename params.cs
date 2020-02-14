using System;

namespace method_params
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            //Passing by value
            //Program.SimpleMethod(ref i);
            // Console.WriteLine(i);


           /* int tot = 0;
            int prod = 0;
            Calculate(10, 20, out tot, out prod);
            Console.WriteLine("{0} {1}",tot,prod);*/

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            ParamsMethod(numbers);
        }
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }
        public static void Calculate(int FN,int SN, out int Sum,out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0] elements",Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}

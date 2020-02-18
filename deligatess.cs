using System;

namespace Multicastdeligates
{
    public delegate void SampleDelegate(out int Integer);
    class Program
    {
        static void Main(string[] args)
        {
            /* SampleDelegate del1, del2, del3, del4;
             del1 = new SampleDelegate(SampleMethodOne);
             del2 = new SampleDelegate(SampleMethodTwo);
             del3 = new SampleDelegate(SampleMethodThree);
             //Multicast delegate point to more than one function.
             del4 = del1 + del2 + del3;
             del4 -= del2;
             del4();*/

            SampleDelegate del = new SampleDelegate(SampleMethodTwo);
            del += SampleMethodOne;
            //del += SampleMethodThree;
            //del -= SampleMethodTwo;
           int delegateOutputParameterValue =  -1;
            del(out delegateOutputParameterValue);
            Console.WriteLine("delegateOutputParameterValue is {0}", delegateOutputParameterValue);
        }
        /*public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static int SampleMethodTwo()
        {
            return 2;
        }
        public static int SampleMethodOne()
        {
            return 1;
        }*/
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
    }
}

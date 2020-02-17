using System;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        public static void Main(string[] args)
        {
            //A delegate is a type safe pointer
            //ot must match the signature of the function
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}

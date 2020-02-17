using System;

namespace InterfaceImplementation
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class Program : I1, I2
    {
        static void Main(string[] args)
        {
            I2 p2 = new Program();
            I1 p1 = new Program();
            //if a class inherites from 2 or more interfaces with same method use explicit interface typecasting
            Program p = new Program();
            p.InterfaceMethod();
            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();
            p2.InterfaceMethod();
            p1.InterfaceMethod();
        }

        //public void InterfaceMethod()
        //{
         //   Console.WriteLine("I2 Interface Method");
        //}
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
    }
}

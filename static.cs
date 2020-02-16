using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Area = c1.CalculateArea();
            Console.WriteLine("Area is = {0}",Area);

            Circle c2 = new Circle(6);
            float Area1 = c2.CalculateArea();
            Console.WriteLine("Area1 is = {0}", Area1);
            //static members are invoked using the name 
            //of the class and instance mebers are invokked using 
            //an object of the class
            //declaring an intance static saves memory

            //To initialize an instance field we use an
            //instance constructor to initialie a static field we use 
            //a static constructor

        }
    }
    class Circle
    {
        //Instance menbers dont have a static keyword
        static float _PI = 3.14F;
        float _Radius;
        static Circle()
        {
            Circle._PI = 3.14F;
        }



        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return this._Radius * this._Radius * Circle._PI;
        }
    }
}

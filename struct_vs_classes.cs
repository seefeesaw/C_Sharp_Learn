using System;

namespace classes_vs_structs
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //System.Int32 i = 0;
            /*if (i == 10)
            {
                int j = 20;
                Customer c1 = new Customer();
                c1.ID = 101;
                c1.Name = " Mark";
            }*/

            int i = 10;
            int j = i;
            j += 1;

            Console.WriteLine("I = {0}, J = {1}",i,j);

            Customer c1 = new Customer();
            c1.ID = 101;
            c1.Name = "Mark";

            Customer c2 = c1;

            c1.Name = "Mary";
            Console.WriteLine("c1.Name = {0} c2.Name = {1}",c1.Name,c2.Name);

            //classes can have distructors structs cannot
            //structs cannot have parametersless constructors
            //a struct or class cannot inherit from another struct
            //sealed classes cannot be inherited.
        }
    }
}

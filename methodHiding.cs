using System;

namespace Method_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Fulltime";
            fte.LastName = "Employee";
            fte.PrintFullName();

            //PartTimeEmployee pte = new PartTimeEmployee();
            //Parent class reference variables can point to child class objects
            //a parent class reference variable can point to a child class object
            Employee pte = new PartTimeEmployee();
            pte.FirstName = "PartTime";
            pte.LastName = "Employee";
            //Typecasting
            //((Employee)pte).PrintFullName();
        }
    }
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName+" "+LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        //use new keyword to hide abase class member
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();
           // Console.WriteLine(FirstName + " " + LastName+"- Contractor");
        }
    }
}

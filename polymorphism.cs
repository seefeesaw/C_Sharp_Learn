using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //e.PrintFullNmae();


            //Polymorphism enables you to envoke derived class methods
            //through base class methods at run time. if the child class
            //if the child class is overriding the base class method.
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[0] = new FullTimeEmployee();
            employees[0] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullNmae();
            }

        }
    }
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullNmae()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullNmae()
        {
            base.PrintFullNmae();
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullNmae()
        {
            Console.WriteLine(FirstName + " " + LastName+" Full Time");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullNmae()
        {
            Console.WriteLine(FirstName + " " + LastName+" Temporary");
        }
    }
}

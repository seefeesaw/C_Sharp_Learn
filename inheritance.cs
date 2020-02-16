using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance allows for code re-use
            //c# suuports single inheritence
            //Multi level inheritance is allowed
            //Parent class constructors are executed before
            //child class constructors

            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "seefeesaw";
            fte.LastName = "shongwe";
            fte.YearlySalary = 5000000;
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "seefeesaw";
            pte.LastName = "shongwe";
            pte.HourlyRate = 1250;
            pte.PrintFullName();
        }
    }

    public class Employeee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
    public class FullTimeEmployee : Employeee
    {
        public float YearlySalary;
    }
    public class PartTimeEmployee : Employeee
    {
        public float HourlyRate;
    }
}


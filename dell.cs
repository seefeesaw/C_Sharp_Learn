using System;
using System.Collections.Generic;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 111, Name = "Money", Salary = 4000, Experience = 2 });
            emplist.Add(new Employee() { ID = 121, Name = "Mike", Salary = 6000, Experience = 4 });
            emplist.Add(new Employee() { ID = 131, Name = "John", Salary = 2000, Experience = 6 });
            emplist.Add(new Employee() { ID = 141, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(emplist,isPromotable);
       
        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist,IsPromotable isEligableToromote)
        {
            foreach(Employee employee in employeelist)
            {
                if (isEligableToromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}

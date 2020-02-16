using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //namespaces help you organise code
            //using fully qualified names helps
            //you see where the namespace is coming from
            Console.WriteLine("");
            PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}


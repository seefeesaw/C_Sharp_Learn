using System;

namespace tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops

            //while loop
            /*Console.WriteLine("Please enter your target?");
            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;
            while (start <= UserTarget)
            {
                Console.Write(start+" ");
                start += 1;
            }

           // Console.WriteLine("Please enter your target?");
           // int UserTarget = int.Parse(Console.ReadLine());
            

            //USE DO WHILE LOOPS INSTEAD OF GOTO STATEMENTS
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter your target?");
                int UserTarget = int.Parse(Console.ReadLine());
                int start = 0;

                while (start <= UserTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }
                do
                {
                    Console.WriteLine("Do you want continue - Yes or No?");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, please say Yes or No");
                    }


                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");*/

            /*int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int j = 0; j<numbers.Length;j++)
            {
                Console.WriteLine(numbers[j]);
            }
            Console.WriteLine("\n");
            int i = 0;
            while (i <numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
            Console.WriteLine("\n");

            //No out of bound Exception with a foreach
            foreach (int itm in numbers)
            {
                Console.WriteLine(itm);
            }
            */

            //break and continue

            for (int i = 0; i  <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
                if (i == 10)
                    break;
            }

        }
    }
}


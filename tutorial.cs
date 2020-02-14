using System;

namespace TutorialCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Comments

            //Console.WriteLine("Hello");

            //Console.WriteLine("Hello");

            /*Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");*/

            //Comment complicated code

            //ctrl+C+u to  commnent ctrl+c+u to uncomment
            //Console.WriteLine("Hello");


            //Console.WriteLine("Please enter a number ");
            /*int UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber == 1)
            {
                Console.WriteLine("Your Number is one");
            }
            if (UserNumber == 2)
            {
                Console.WriteLine("Your Number is two");
            }
            if (UserNumber == 3)
            {
                Console.WriteLine("Your Number is threee");
            }
            if (UserNumber != 2 && UserNumber != 2 && UserNumber != 3)
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            }
            int Number;
            if(int.TryParse(Console.ReadLine(),out Number))
            {
                if (Number == 1)
                {
                    Console.WriteLine("Your Number is one");
                }
                else if (Number == 2)
                {
                    Console.WriteLine("Your Number is two");
                }
                else if (Number == 3)
                {
                    Console.WriteLine("Your Number is threee");
                }
                //short circuit operators

                //only check the first condition if its true and  excecute the statement
                //checks the second condition if the first condition is not true
                //it is much faster
                else if (Number == 10 || Number == 20)
                {
                    Console.WriteLine("Your Number is 10 or 20");
                }
                //always checks both conditions before excuting the statement
                //much slower
                else if (Number == 30 | Number == 50)
                {
                    Console.WriteLine("Your Number is 30 or 50");
                }
                //only check the first condition if its false and dont excecute the statement
                //checks the second condition if the first condition is true
                //it is much faster
                else if (Number != 2 && Number != 2 && Number != 3)
                {
                    Console.WriteLine("Your Number is not between 1 and 3");
                }
                //always checks both conditions before excuting the statement
                //much slower
                else if (Number != 2 && Number != 2 && Number != 3)
                {
                    Console.WriteLine("Your Number is not between 1 and 3");
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }*/


            //Switch statement

            // Console.WriteLine("Please enter a number");
            //int UserNumber = int.Parse(Console.ReadLine());
            /* if (UserNumber==10)
             {
                 Console.WriteLine("Your Number 10");
             }
             else if (UserNumber == 20)
             {
                 Console.WriteLine("Your Number 20");
             }
             else if (UserNumber == 30)
             {
                 Console.WriteLine("Your Number 30");
             }
             else
             {
                 Console.WriteLine("Your number is not 10, 20, & 30");
             }*/

            /*switch(UserNumber)
            {
                case 10:
                    Console.WriteLine("Your Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your Number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;
            }*/

            //combining multiple switch statements together

            /*switch (UserNumber)
            {
                case 10:
                    
                case 20:
                   
                case 30:
                    Console.WriteLine("Your Number is {0}",UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;
            }

            int TotalCoffeCost = 0;
            //start is a labell to identify a location where you want the control to come back
            start:
            Console.WriteLine("1 - small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Line Choice {0} is invalid",UserChoice);
                    goto start;
            }

            decided:
            Console.WriteLine("Do You want to buy anothe coffe - Yes or No?");
            string UserDecision = Console.ReadLine();
            
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice is Invalid {0} ...Please try again",UserChoice);
                    goto decided;
            }

            Console.WriteLine("Thank you for shopping with us\nBill Amount = " +
                "{0} ", TotalCoffeCost);*/

            Console.WriteLine("Please enter your target?");
            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;
            while (start <=  UserTarget)
            {
                Console.WriteLine(start);
                start += 1;
            }

        }
    }
    //XML Doumentation comments for ducumentation.

    /// <summary>
    /// This is a sample class and a sample documentation
    /// </summary>
    public class SampleClass
    { }

}

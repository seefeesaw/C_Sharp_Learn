
namespace OPP1
{
    class Program
    {
        //static method
        public static void Main(string[] args)
        {
            //instance methods are invoked using an instance of the class
            Program p = new Program();
            //Static methods are invoked using name of the class
            Program.EvenNumbers(50);
            int sum = p.Add(5,9);
            Console.WriteLine("Sum is : {0}",sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        //instance method
        public static void EvenNumbers(int Target)
        {
            int start = 0;
            while (start <= Target)
            {
                Console.WriteLine(start);
                start += 2;

            }
        }
    }
}

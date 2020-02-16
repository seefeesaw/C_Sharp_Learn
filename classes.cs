namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Seefeesaw","Shongwe");
            c1.PrintFullNmae();
        }
    }
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string firstName,string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public void PrintFullNmae()
        {
            Console.WriteLine("Full Nmae = {0}", this._firstName + " " + this._lastName);
        }

        ~Customer()
        {
            //Clean Up Code

        }
    }
}

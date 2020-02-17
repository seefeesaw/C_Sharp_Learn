using System;

namespace Structs
{
    public struct Customer
    {
        private int _id;
        private string _name;

        

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}",this.Id,this.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101,"Mark");
            c1.PrintDetails();

            Customer C2 = new Customer();
            C2.Id = 102;
            C2.Name = "jOHN";
            C2.PrintDetails();

            //Object initializer syntax
            Customer c3 = new Customer()
            {
                Id = 103,
                Name = "Rob"
            };
        }
    }
}








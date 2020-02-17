using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.Id = 101;
            c1.Name = "Seefeesaw";


            //Console.WriteLine("ID = {0] && nMAE = {1} && pASSmARK = {2}",c1.ID,c1.Name,c1.PasssMark);
            Console.WriteLine("Student id = {0} Name = {1}",c1.Id, c1.Name);

        }
    }
    public class Student
    {
        private int _id;
        private string _name;
        private int _passsMark;

        public int PassMark
        {
            get
            {
                return this._passsMark;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
       
    }
}


using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.SetId(101);

            //Console.WriteLine("ID = {0] && nMAE = {1} && pASSmARK = {2}",c1.ID,c1.Name,c1.PasssMark);
            Console.WriteLine("Student id = {0}",c1.GetId());

        }
    }
    public class Student
    {
        private int _id;
        private string _name;
        private int _passsMark;

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Nmae cannot be null or empty");
            }
            this._name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            /*if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }*/
        }
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;
        }
    }
}

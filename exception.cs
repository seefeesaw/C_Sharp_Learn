using System;
using System.IO;

namespace ExceptionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"C:\Users\abel.shongwe\Desktop\content/seee.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                /*Console.WriteLine(e.FileName);
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);*/
                Console.WriteLine("Please Check if the file {0} exists",e.FileName);
            }
        }
    }
}

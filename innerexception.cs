using System;
using System.IO;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception e)
                {
                    string filePath = @"C:\Users\abel.shongwe\Desktop\Log_File";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(e.GetType().Name);
                        sw.Write(e.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", e);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Current Exception = {0}", ex.GetType().Name);
                Console.WriteLine("Inner Exception = {0}",ex.InnerException.GetType().Name);
            }
        }
    }
}

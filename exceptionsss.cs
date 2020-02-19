using System;
using System.IO;

namespace ExceptionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\abel.shongwe Desktop\content/seee.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                
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
            //put general exceptions at the bottom and more specific ones at the top
            catch (Exception e)
            {
                Console.WriteLine("Please check if the file {0} exists", e.Message);
            }
            //Its important for releasing sources properly even in case of an exception at catch blocks
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }
        }
    }
}

using System;
using System.IO;
using System.Runtime.Serialization;

namespace Custom_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new FileNotFoundException("File not XYZ is not found");
            try
            {
                throw new UserAlreadyLoggedInException("User already logged in");
            }catch (UserAlreadyLoggedInException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base() { }
        public UserAlreadyLoggedInException(string meesage) : base(meesage) { }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException) { }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext contect) : base(info, contect) { }
    }
}

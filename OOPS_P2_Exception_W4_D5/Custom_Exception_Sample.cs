using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_P2_Exception_W4_D5
{
    // Custom exceptions are user-defined exceptions that can be created by inheriting from the base Exception class. They allow developers to create specific exception types that are relevant to their application's domain, providing more meaningful error messages and better error handling. Custom exceptions can include additional properties and methods to provide more context about the error, making it easier for developers to diagnose and fix issues in their code.
    public class CustomException : Exception
    {
        public int ErrorCode { get; set; }
        public CustomException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
    public class SampleClass
    {
        public void SampleMethod()
        {
            try
            {
                // Simulating an error condition
                throw new CustomException("An error occurred in SampleMethod.", 1001);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex.Message}, Error Code: {ex.ErrorCode}");
            }
        }
    }
    internal class Custom_Exception_Sample
    {
        static void Main(string[] args)
        {
            SampleClass objSample = new SampleClass();
            objSample.SampleMethod();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_P2_Exception_W4_D5
{
    public class InvalidEmpIDException : Exception
    {
        public InvalidEmpIDException(string message) : base(message)
        {

        }
    }
    class UserDefinedException
    {
        public static  void ValidatEmpId(int Id) // validating method 
        {
            if (Id != 1000)
            {
                throw new InvalidEmpIDException(" The employee Id does not exist");

            }
            else
            {
                Console.WriteLine("Valid Employee Id");
                Console.ReadLine();
            }
        }
    }


        internal class Custom_Exception_V2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Employee Id:");
                int empId = Convert.ToInt32(Console.ReadLine());
                UserDefinedException.ValidatEmpId(empId); // method call to validate employee id from a static method of UserDefinedException class
            }
            catch (InvalidEmpIDException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block will always execute.");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

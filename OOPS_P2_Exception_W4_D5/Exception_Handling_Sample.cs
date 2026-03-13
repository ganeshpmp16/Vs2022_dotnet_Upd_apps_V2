using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_P2_Exception_W4_D5
{
    internal class Exception_Handling_Sample
    {
        static void Main(string[] args)
        {
            try // try block is used to wrap code that may throw an exception. It allows you to handle exceptions gracefully without crashing the program.
            {
                Console.WriteLine("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex) // catch block is used to handle specific exceptions that may occur in the try block. In this case,
                                             // it catches the DivideByZeroException, which occurs when attempting to divide by zero.
            {
                Console.WriteLine("Error: Cannot divide by zero. " +ex.Message );
               // Console.WriteLine("Stack Trace: " + ex.StackTrace);
               // Console.WriteLine("Source: " + ex.Source);
            }
            catch (FormatException ex) // This catch block handles the FormatException, which occurs when the input cannot be converted to an integer (e.g., if the user enters a non-numeric value).
            {
                Console.WriteLine("Error: Invalid input format. " + ex.Message);
            }
            catch (Exception ex) // This catch block is a general catch-all for any other exceptions that may occur.
                                 // It catches any exception that is not specifically handled by the previous catch blocks.
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

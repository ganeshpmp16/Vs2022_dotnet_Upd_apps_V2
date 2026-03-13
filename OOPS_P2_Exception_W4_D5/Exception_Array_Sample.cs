using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_P2_Exception_W4_D5
{
    internal class Exception_Array_Sample
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine("Enter an index to access the array:");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Value at index " + index + ": " + numbers[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
                if(ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                else
                    Console.WriteLine("Error: Index is out of range. " + ex.Message);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsApp_W4_D4
{
    // collections namespace to hold any collection-related classes or methods (e.g., linked list, stack, queue, etc.)
    internal class Collectionns
    {
        // stack exmaple 
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); // create a stack of integers
            stack.Push(10); // push some values onto the stack
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Values in the stack:"); // print the values in the stack
            while (stack.Count > 0) // while the stack is not empty, pop and print the top value
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine("\nEnd of the stack."); // print a message indicating the end of the stack
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Trees_App_W4_D5
{ // struct in C# is a value type that can encapsulate data and related functionality.
  // It is similar to a class but has some differences, such as being a value type and not supporting inheritance. Structs are typically used for small

  // lightweight objects that do not require the overhead of a class.
    struct Point // define a value type called Point to represent a point in 2D space
    {
        public int X { get; set; } // Property to store the X coordinate of the point
        public int Y { get; set; } // Property to store the Y coordinate of the point
        public Point(int x, int y) // Constructor to initialize the point with X and Y coordinates
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
    internal class Struct_Sample
    {
        static void Main(string[] args)
        {
            Point structP1 = new Point(3, 4); // Create a new Point struct instance with X=3 and Y=4
            structP1.Display(); // Call the Display method to print the point's coordinates
            Point structP2 = structP1; // Create a new Point struct instance by copying structP1
            structP2.Display();
            structP2.X = 10; // Modify the X coordinate of structP2
            structP2.Y = 20; // Modify the Y coordinate of structP2
            Console.WriteLine("After modifying structP2:");
            structP1.Display(); // Display structP1 to show that it remains unchanged
            structP2.Display(); // Display structP2 to show the updated coordinates
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

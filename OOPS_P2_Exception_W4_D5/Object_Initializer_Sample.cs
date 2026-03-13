using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_P2_Exception_W4_D5
{
    class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Staff() { }
        public Staff(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
        // expression-bodied member to override ToString() method to return full name
        public override string ToString() => FirstName + " " + LastName;// overriding ToString() method to return full name using object initializer
        // lambda like arrow  operator => is used to define an expression-bodied member, which is a concise way to implement a method that consists of a single expression. In this case, the ToString() method is overridden to return the full name of the staff member by concatenating the FirstName and LastName properties with a space in between.
        public int Add(int a, int b) => a + b; // expression-bodied member to add two numbers
    }


    internal class Object_Initializer_Sample
    {
        static void Main(string[] args)
        {
            // using constructor
            Staff staff1 = new Staff("John", "Doe");
            Console.WriteLine(staff1);
            // using object initializer
            Staff staff2 = new Staff { FirstName = "Jane", LastName = "Smith" };
            Console.WriteLine(staff2);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // Staff objStaff1 = new Staff("Stuart", "Broad");
            Staff objStaff2 = new Staff  // object initializer
            {
                FirstName = "Stuart",
                LastName = "Broad"
            };

            // Console.WriteLine(objStaff1.ToString());
            Console.WriteLine(objStaff2.ToString()); //ToString() method is overridden in Staff class to return full name
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsApp_W4_D4
{
    class MyPerson
    {
        public string Name;
        public int Age;
    }
    public record Person(string Name, int Age); // define a record type called Person with two properties: Name and Age
    public record Employee
    {
        // init means properties can only be set during object initialization,
        // making the record immutable after creation.
        // This allows for value-based equality and pattern matching, which are key features of records in C#.

        public int Id { get; init; } // define an init-only property for the employee ID
        public string Name { get; init; } // define an init-only property for the employee name
    }
    record Employee1(string Name,int salary): Person(Name,Age:30);
    record Student(string name,int marks);
    record Product
    {
        public int Id { get; init; } // define an init-only property for the product ID
        public string Name { get; init; } // define an init-only property for the product name
        public decimal Price { get; init; } // define an init-only property for the product price
        // record with a constructor to initialize the properties of the Product record
        public Product(int id, string name, decimal price) // constructor to initialize the properties of the Product record
        {
            Id = id; // set the Id property
            Name = name; // set the Name property
            Price = price; // set the Price property
        }
    }
    // record struct example to demonstrate how to use record structs in C# to
    // create value types that can be used for efficient data storage and manipulation

    record struct Point(int X, int Y); // define a record struct called Point with two properties: X and Y
    internal class Reduce_Record
    {
        // javascript reduce equivalent in C# to demonstrate how to use LINQ's Aggregate method to perform a reduction operation on a collection of data
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; // create a list of integers
            int sum = numbers.Aggregate((acc, x) => acc + x); // use the Aggregate method to sum the numbers in the list
            Console.WriteLine("Sum of the numbers: " + sum); // print the result of the reduction operation
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // hashing example to demonstrate how to use the GetHashCode method to generate a hash code for an object in C#
            // hashing converts data into a fixed-size value (hash code) that represents the original data, which can be used for efficient data retrieval and storage
            string str = "Hello, World!"; // create a string object
            int hashCode = str.GetHashCode(); // generate a hash code for the string object
            Console.WriteLine("Hash code for the string: " + hashCode); // print the generated hash code
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // records example to demonstrate how to use records in C# to create immutable data types that can be used for value-based equality and pattern matching
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Alice", 30);
            Console.WriteLine("Person 1: " + person1); // print the first person object
            Console.WriteLine("Person 2: " + person2); // print the second person object
            Console.WriteLine("Are person1 and person2 equal? " + (person1 == person2)); // check if the two person objects are equal using value-based equality
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            MyPerson p1 = new MyPerson { Name = "Bob", Age = 25 }; // create an instance of MyPerson
            MyPerson p2 = new MyPerson { Name = "Bob", Age = 25 }; // create another instance of MyPerson with the same values
            Console.WriteLine(p1==p2); // print the first MyPerson object
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            Employee recEmp = new Employee { Id = 1, Name = "Charlie" }; // create an instance of the Employee record
            Console.WriteLine(recEmp.Id); // print the Employee record id
            Console.WriteLine(recEmp.Name); // print the Employee record name
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // record with expressions
            Student s1 = new Student("David", 85); // create an instance of the Student record
            Student s2 = s1 with { marks = 90 }; // create a new instance of the Student record by copying s1 and changing the marks property
            Console.WriteLine(s1); // print the original Student record
            Console.WriteLine(s2); // print the new Student record with updated marks
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            // record with a constructor
            Product prod1 = new Product(1, "Laptop", 999.99m); // create an instance of the Product record using the constructor
            Console.WriteLine(prod1.Id); // print the Product id
            Console.WriteLine(prod1.Name); // print the Product name
            Console.WriteLine(prod1.Price); // print the Product price
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // record with inheritance
            Employee1 recEmp1 = new Employee1("Eve", 50000); // create an instance of the Employee1 record
            Console.WriteLine(recEmp1.Name); // print the Employee1 record name
            Console.WriteLine(recEmp1.salary); // print the Employee1 record salary
            Console.WriteLine(recEmp1.Age); // print the Employee1 record age inherited from the Person record
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // record struct example
            Point point1 = new Point(3, 4); // create an instance of the Point record struct
            Console.WriteLine(point1); // print the Point record struct
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console

        }
    }
}

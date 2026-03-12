using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsApp_W4_D4
{
    internal class Queue_Sample
    {
        // queue example to demonstrate the use of the Queue collection in C#
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(); // create a queue of strings
            queue.Enqueue("Alice"); // enqueue some values into the queue
            queue.Enqueue("Bob");
            queue.Enqueue("Charlie");
            Console.WriteLine("Values in the queue:"); // print the values in the queue
            while (queue.Count > 0) // while the queue is not empty, dequeue and print the front value
            {
                Console.Write(queue.Dequeue() + " ");
            }
            Console.WriteLine("\nEnd of the queue."); // print a message indicating the end of the queue
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // HashSet example to demonstrate the use of the HashSet collection in C#
            HashSet<int> hashSet = new HashSet<int>(); // create a hash set of integers
            hashSet.Add(10); // add some values to the hash set
            hashSet.Add(20);
            hashSet.Add(30);
            Console.WriteLine("Values in the hash set:"); // print the values in the hash set
            foreach (int value in hashSet) // iterate through the hash set and print each value
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\nEnd of the hash set."); // print a message indicating the end of the hash set
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // arraylist example to demonstrate the use of the ArrayList collection in C#
            ArrayList arrayList = new ArrayList(); // create an array list
            arrayList.Add(10); // add some values to the array list
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            Console.WriteLine("Values in the array list:"); // print the values in the array list
            foreach (object value in arrayList) // iterate through the array list and print each value
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\nEnd of the array list."); // print a message indicating the end of the array list
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // hash table example to demonstrate the use of the Hashtable collection in C#
            // it is key-value pair collection that uses a hash function to compute the hash code of the keys and store the values in buckets based on the hash code
            Hashtable hashTable = new Hashtable(); // create a hash table
            hashTable.Add("Name", "Alice"); // add some key-value pairs to the hash table
            hashTable.Add("Age", 30);
            hashTable.Add("City", "New York");
            Console.WriteLine("Values in the hash table:"); // print the values in the hash table
            foreach (DictionaryEntry entry in hashTable) // iterate through the hash table and print each key-value pair
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine("End of the hash table."); // print a message indicating the end of the hash table
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // List example to demonstrate the use of the List collection in C#
            List<double> list = new List<double>(); // create a list of doubles
            list.Add(3.14); // add some values to the list
            list.Add(2.718);
            list.Add(1.618);
            Console.WriteLine("Values in the list:"); // print the values in the list
            foreach (double value in list) // iterate through the list and print each value
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\nEnd of the list."); // print a message indicating the end of the list
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            // Dictionary example to demonstrate the use of the Dictionary collection in C#
            Dictionary<string, int> dictionary = new Dictionary<string, int>(); // create a dictionary with string keys and int values
            dictionary.Add("Alice", 10); // add some key-value pairs to the dictionary
            dictionary.Add("Bob", 20);
            dictionary.Add("Charlie", 30);
            Console.WriteLine("Values in the dictionary:"); // print the values in the dictionary
            foreach (KeyValuePair<string, int> entry in dictionary) // iterate through the dictionary and print each key-value pair
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            // sorting an array of integers using the Array.Sort method
            int[] array = { 5, 2, 8, 1, 3 }; // create an array of integers
            Console.WriteLine("Original array:"); // print the original array
            foreach (int value in array) // iterate through the array and print each value
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\nSorted array:"); // print the sorted array
            Array.Sort(array); // sort the array in ascending order
            foreach (int value in array) // iterate through the sorted array and print each value
            {
                Console.Write(value + " ");
            }
            // sort an array of integers without using the built-in Array.Sort method (using bubble sort algorithm)
            int[] array2 = { 5, 2, 8, 1, 3 }; // create another array of integers
            Console.WriteLine("\nOriginal array:"); // print the original array
            foreach (int value in array2) // iterate through the array and print each value
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\nSorted array (using bubble sort):"); // print the sorted array
            // bubble sort algorithm to sort the array in ascending order
            for (int i = 0; i < array2.Length - 1; i++) // outer loop to iterate through the array
            {
                for (int j = 0; j < array2.Length - i - 1; j++) // inner loop to compare adjacent elements
                {
                    if (array2[j] > array2[j + 1]) // if the current element is greater than the next element, swap them
                    {
                        int temp = array2[j]; // store the current element in a temporary variable
                        array2[j] = array2[j + 1]; // set the current element to the next element
                        array2[j + 1] = temp; // set the next element to the temporary variable (original current element)
                    }
                }
            }
            foreach (int value in array2) // iterate through the sorted array and print each value
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\nEnd of the sorted array."); // print a message indicating the end of the sorted array
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // wait for user input before closing the console
            List<int> numbers = new List<int> { 1,2,3 };
            numbers.Add(2);
            numbers.Add(4);// create a list of integers
            Console.WriteLine(numbers.Count);
            Console.WriteLine("print any key to exit");
            Console.ReadLine();

            // create an array of integers
            


        }
    }
}

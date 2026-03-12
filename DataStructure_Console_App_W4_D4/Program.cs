namespace DataStructure_Console_App_W4_D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simple array sample 
           // int[] arrNumbers = new int[5];
            int[] arrNumbers2 = new int[] { 1, 2, 3, 4, 5 };
            arrNumbers2[2] = 10; // change the value of the element at index 2 to 10
            Console.WriteLine("Array of numbers:");
            for (int i = 0; i < arrNumbers2.Length; i++)
            {
                Console.Write(arrNumbers2[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            //add and remove elements  using arrays
            arrNumbers2 = arrNumbers2.Append(6).ToArray(); // add an element to the end of the array
            Console.WriteLine("Array of elemennts after adding element at the end of the array");
            for (int i = 0; i < arrNumbers2.Length; i++)
            {
                Console.Write(arrNumbers2[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // remove the last  element from the array
            arrNumbers2 = arrNumbers2.Take(arrNumbers2.Length - 1).ToArray();
            Console.WriteLine("Array of numbers after removing the last element:");
            for (int i = 0; i < arrNumbers2.Length; i++)
            {
                Console.Write(arrNumbers2[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // transform the elements of the arry with the select method imitating map() method in javascript
            // select method is used to project each element of a sequence into a new form
            arrNumbers2 = arrNumbers2.Select(x => x * 2).ToArray(); // multiply each element by 2
            Console.WriteLine("Array of numbers after multiplying each element by 2:");
            for (int i = 0; i < arrNumbers2.Length; i++)
            {
                Console.Write(arrNumbers2[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // filter the elements of the array with the where method imitating filter() method in javascript
            // where method is used to filter a sequence of values based on a predicate
            arrNumbers2 = arrNumbers2.Where(x => x > 5).ToArray(); // keep only the elements that are greater than 5
            Console.WriteLine("Array of numbers after keeping only the elements that are greater than 5:");
            for (int i = 0; i < arrNumbers2.Length; i++)
            {
                Console.Write(arrNumbers2[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            // List  as an dynamic array sample
            List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5 };
            listNumbers.Add(6); // add an element to the end of the list
            Console.WriteLine("List of numbers after adding element at the end of the list:");
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write(listNumbers[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            List<string> personNames = new List<string>() { "Alice", "Bob", "Charlie" };
            personNames.Add("David"); // add an element to the end of the list
            Console.WriteLine("List of person names after adding element at the end of the list:");
            for (int i = 0; i < personNames.Count; i++)
            {
                Console.Write(personNames[i] + " ");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}

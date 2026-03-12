namespace LinkedListsApp_W4_D4
{
    internal class Program
    {
        // create a linked list of integers and print the values
        public class Node
        {
            // properties
            public int Data { get; set; }
            public Node Next { get; set; }
            // constructor
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        public class LinkedList
        {
            Node head; // head of the list used to keep track of the first node
            // method to add a node to the end of the list
            public void Add(int data)
            {
                Node newNode = new Node(data); // create a new node with the given data
                if (head == null) // if the list is empty, set the new node as the head
                {
                    head = newNode; // set the new node as the head of the list
                    return;
                }
                Node current = head; // start from the head and traverse to the end of the list
                while (current.Next != null) // while the next node is not null, move to the next node
                {
                    current = current.Next;  // move to the next node
                }
                current.Next = newNode; // set the next of the last node to the new node
            }
            // method to print the values of the list
            public void Print()
            {
                Node current = head; // start from the head and traverse the list, printing the data of each node
                while (current != null) // while the current node is not null, print the data and move to the next node
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
               
            }
        }
        static void Main(string[] args)
        {
           LinkedList list = new LinkedList(); // create a new linked list
            list.Add(10); // add some values to the list
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine("Values in the linked list:"); // print the values in the list
            list.Print();
            Console.WriteLine("\nEnd of the linked list."); // print a message indicating the end of the list
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // wait for the user to press a key before exiting
        }
    }
}

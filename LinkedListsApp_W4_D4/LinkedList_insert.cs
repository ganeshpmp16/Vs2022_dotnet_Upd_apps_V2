using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsApp_W4_D4
{
    class MyNode // Node class representing each element in the linked list
    {
        public int Data { get; set; } // Property to hold the data of the node
        public MyNode Next { get; set; } // Property to hold the reference to the next node in the list
        public MyNode(int data) // Constructor to initialize the node with data and set the next reference to null
        {
            Data = data;
            Next = null;
        }
    }
    class MyLinkedList
    {
        public MyNode Head { get; set; } // Property to hold the reference to the head of the linked list
        public MyLinkedList() // Constructor to initialize the linked list with the head set to null
        {
            Head = null;
        }
        public void InsertAtEnd(int data) // Method to insert a new node with the given data at the end of the linked list
        {
            MyNode newNode = new MyNode(data);// Create a new node with the provided data
            if (Head == null) // If the linked list is empty, set the new node as the head of the list
            {
                Head = newNode;
                return;
            }
            MyNode temp = Head; // Start from the head of the list and traverse to the end
            while (temp.Next != null) // Continue traversing until the last node is reached (where Next is null)
            {
                temp = temp.Next; // Move to the next node in the list
            }
            temp.Next = newNode; // Set the Next reference of the last node to the new node, effectively adding it to the end of the list
        }
        // Additional methods for the linked list can be added here (e.g., InsertAtBeginning, DeleteNode, etc.)
        public void InsertAtBeginning(int data) // Method to insert a new node with the given data at the beginning of the linked list
        {
            MyNode newNode = new MyNode(data); // Create a new node with the provided data
            newNode.Next = Head; // Set the Next reference of the new node to the current head of the list
            Head = newNode; // Update the head of the list to be the new node
        }
        // Mehtod to delete a node with the specified data from the linked list
        public void DeleteNode(int data)
        {
            if (Head == null) // If the linked list is empty, there is nothing to delete
            {
                return;
            }
            if (Head.Data == data) // If the head node contains the data to be deleted, update the head to the next node
            {
                Head = Head.Next;
                return;
            }
            MyNode temp = Head; // Start from the head of the list and traverse to find the node to delete
            while (temp.Next != null) // Continue traversing until the end of the list is reached
            {
                if (temp.Next.Data == data) // If the next node contains the data to be deleted, update the Next reference to skip it
                {
                    temp.Next = temp.Next.Next; // Bypass the node to be deleted
                    return;
                }
                temp = temp.Next; // Move to the next node in the list
            }
        }

        // Method to display the contents of the linked list
        public void Display()
        {
            MyNode temp = Head; // Start from the head of the list
            while (temp != null) // Continue traversing until the end of the list is reached
            {
                Console.Write(temp.Data + " "); // Print the data of the current node followed by a space
                temp = temp.Next; // Move to the next node in the list
            }
            Console.WriteLine(); // Print a new line after displaying all nodes
            Console.WriteLine("End of list"); // Indicate the end of the list
            Console.WriteLine("Press any to key to exit");
            Console.ReadLine(); // Wait for user input before closing the console
        }
    }
    internal class LinkedList_insert
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList(); // Create a new instance of the MyLinkedList class
            list.InsertAtBeginning(5);
            
            list.InsertAtEnd(10); // Insert nodes with data at the end of the linked list
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);

            // Insert a node with data at the beginning of the linked list
            list.DeleteNode(20); // Delete a node with specific data from the linked list

            Console.WriteLine("Contents of the linked list:"); // Print a message indicating the contents of the linked list
            list.Display(); // Display the contents of the linked list
        }
    }
}

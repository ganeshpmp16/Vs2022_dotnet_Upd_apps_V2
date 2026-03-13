namespace Struct_Trees_App_W4_D5
{
    
    class Node
    {
       public int Data { get; set; } // The value stored in the node
        public Node Left { get; set; } // Reference to the left child node
        public Node Right { get; set; } // Reference to the right child node
        public Node(int value) // Constructor to initialize the node with a value
        {
            Data = value; // Set the data value of the node
            Left = null; // Initialize the left child reference to null
            Right = null; // Initialize the right child reference to null
        }
    }
    class BinaryTree
    {
        public Node root; // The root node of the binary tree
        // inorder traversal: left, root, right
      public void Inorder(Node node)
        {
            if (node != null) // Check if the current node is not null
            {
                Inorder(node.Left); // Recursively traverse the left subtree
                Console.Write(node.Data + " "); // Print the data of the current node
                Inorder(node.Right); // Recursively traverse the right subtree
            }
            else
            {
                return; // Base case: if the node is null, return from the function
            }
        }
        // preorder traversal: root, left, right
        public void Preorder(Node node)
        {
            if (node != null) // Check if the current node is not null
            {
                Console.Write(node.Data + " "); // Print the data of the current node
                Preorder(node.Left); // Recursively traverse the left subtree
                Preorder(node.Right); // Recursively traverse the right subtree
            }
            else
            {
                return; // Base case: if the node is null, return from the function
            }
        }
        // postorder traversal: left, right, root
        public void Postorder(Node node)
        {
            if (node != null) // Check if the current node is not null
            {
                Postorder(node.Left); // Recursively traverse the left subtree
                Postorder(node.Right); // Recursively traverse the right subtree
                Console.Write(node.Data + " "); // Print the data of the current node
            }
            else
            {
                return; // Base case: if the node is null, return from the function
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree objBinarytree = new BinaryTree(); // Create a new instance of the BinaryTree class
            // creating the binary tree structure
            objBinarytree.root = new Node(10); // Set the root node with value 1
            objBinarytree.root.Left = new Node(20); // Set the left child of the root node with value 2
            objBinarytree.root.Right = new Node(30); // Set the right child of the root node with value 3
            objBinarytree.root.Left.Left = new Node(40); // Set the left child of the left child of the root node with value 4
            objBinarytree.root.Left.Right = new Node(50); // Set the right child of the left child of the root node with value 5
            objBinarytree.root.Right.Left = new Node(60); // Set the left child of the right child of the root node with value 6
            objBinarytree.root.Right.Right = new Node(70); // Set the right child of the right child of the root node with value 7
            Console.WriteLine("Inorder Traversal:"); // Print the header for inorder traversal
            objBinarytree.Inorder(objBinarytree.root); // Perform inorder traversal starting from the root node
            Console.WriteLine("\nPreorder Traversal:"); // Print the header for preorder traversal
            objBinarytree.Preorder(objBinarytree.root); // Perform preorder traversal starting from the root node
            Console.WriteLine("\nPostorder Traversal:"); // Print the header for postorder traversal
            objBinarytree.Postorder(objBinarytree.root); // Perform postorder traversal starting from the root node
            Console.WriteLine("\nPress any key to exit..."); // Prompt the user to press a key to exit the program
            Console.ReadKey(); // Wait for the user to press a key before closing the console window
        }
    }
}

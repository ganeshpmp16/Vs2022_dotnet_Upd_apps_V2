using System.Runtime.CompilerServices;

namespace OOPS_P2_Exception_W4_D5
{
    public class MyOrignialClass
    {
        public void Display()
        {
            Console.WriteLine(" i am display method in original class");
        }
        public void Print()
        {
            Console.WriteLine(" i am print method in original class");
        }
        

    }
     static class  ExtenstionClass
    {
        public static void scan(this MyOrignialClass objOriginalClass )
        {
                        Console.WriteLine(" i am scan method in extension class ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           MyOrignialClass objMyOrignialClass = new MyOrignialClass();
            objMyOrignialClass.Display();
            objMyOrignialClass.Print();
            objMyOrignialClass.scan();  // calling the extension method using the original class object
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

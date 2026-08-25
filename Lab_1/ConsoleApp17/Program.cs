// Develop a program to demonstrate the use of a Multicast Delegate. Create two methods named DisplayWelcome()
// and DisplayDateTime(). Create a delegate that invokes both methods sequentially and display the output to demonstrate
// multicast delegate functionality.

using System;

namespace ConsoleApp17
{
    class Program
    {
        public delegate void DisplayDelegate();

        public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to C# Programming!");
        }

        public static void DisplayDateTime()
        {
            Console.WriteLine($"Current Date and Time: {DateTime.Now}");
        }

        static void Main(string[] args)
        {
            DisplayDelegate display;
            display = DisplayWelcome;
            display += DisplayDateTime;
            display();
        }
    }
}
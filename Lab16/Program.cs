// Create a C# program that demonstrates the use of a Single-Cast Delegate. Define a delegate that can reference a
// method for calculating the square of a number. Accept a number from the user, invoke the delegate, and display the
// calculated square.

using System;

namespace Lab16
{
    class Program
    {
        public delegate int SquareDelegate(int number);

        public static int CalculateSquare(int num)
        {
            return num * num;
        }

        static void Main(string[] args)
        {
            SquareDelegate square = CalculateSquare;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = square(number);
            Console.WriteLine($"Square of {number} is {result}");
        }
    }
}
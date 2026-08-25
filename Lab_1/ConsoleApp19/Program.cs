// Create a C# program that demonstrates the use of Anonymous Methods and Lambda Expressions with delegates.
// Write a delegate that performs the addition of two numbers and implement it first using an anonymous method and
// then using a lambda expression. Display the results of both implementations.

using System;

namespace ConsoleApp19
{
    class Program
    {
        public delegate int AddDelegate(int a, int b);

        static void Main(string[] args)
        {
            AddDelegate addAnonymous = delegate(int x, int y)
            {
                return x + y;
            };

            AddDelegate addLambda = (x, y) =>
            {
                return x + y;
            };

            int result1 = addAnonymous(10, 20);
            int result2 = addLambda(10, 20);

            Console.WriteLine("Addition using Anonymous Method: " + result1);
            Console.WriteLine("Addition using Lambda Expression: " + result2);
        }
    }
}
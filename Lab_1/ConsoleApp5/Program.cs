// Create a Calculator class and overload the Add() method to perform addition of two integers, two double values, and

// three integers. Call each overloaded method from the Main() method and display the results to demonstrate compile-
// time polymorphism.

using System;

namespace ConsoleApp5{
    public class Calculator{
        public int Add(int a, int b){
            return a+b;
        }

        public double Add(double a, double b){
            return a+b;
        }

        public int Add(int a, int b, int c){
            return a+b+c;
        }
    }

    class Program{
        static void Main(string[] args){
            Calculator calc = new Calculator();
            Console.WriteLine($"Sum of two integers: {calc.Add(1,8)}");
            Console.WriteLine($"Sum of two doubles: {calc.Add(3.8,5.1)}");
            Console.WriteLine($"Sum of three integers: {calc.Add(4,8,9)}");
        }
    }
}
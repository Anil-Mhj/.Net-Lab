// Create a C# program that implements a Generic Method named Swap<T>() to exchange the
// values of two variables. Demonstrate the method by swapping two integers, two strings, and two
// double values, and display the values before and after swapping.

using System;

namespace ConsoleApp2{
    internal class Swap<T>{
        public T Value1 { get; set; }
        public T Value2 { get; set; }
        
        public Swap(T value1, T value2){
            this.Value1 = value1;
            this.Value2 = value2;
        }
        
        public void SwapValues(){
            T temp = this.Value1;
            this.Value1 = this.Value2;
            this.Value2 = temp;
        }
    }
    
    internal class Program{
        static void Main(string[] args){
            Swap<int> swapInt = new Swap<int>(10, 20);
            Console.WriteLine($"Before swapping: {swapInt.Value1}, {swapInt.Value2}");
            swapInt.SwapValues();
            Console.WriteLine($"After swapping: {swapInt.Value1}, {swapInt.Value2}");
            
            Swap<string> swapString = new Swap<string>("Hello", "World");
            Console.WriteLine($"Before swapping: {swapString.Value1}, {swapString.Value2}");
            swapString.SwapValues();
            Console.WriteLine($"After swapping: {swapString.Value1}, {swapString.Value2}");
            
            Swap<double> swapDouble = new Swap<double>(10.5, 20.5);
            Console.WriteLine($"Before swapping: {swapDouble.Value1}, {swapDouble.Value2}");
            swapDouble.SwapValues();
            Console.WriteLine($"After swapping: {swapDouble.Value1}, {swapDouble.Value2}");
        }
    }
}
// Create a Generic Class named DataStorage<T> that can store and display values of different
// data types such as integer, string, and double. Create objects of the generic class for each data
// type and demonstrate that the same class can be reused for different types.

using System;

namespace ConsoleApp1{
    internal class DataStorage<T>{
        public T Data;

        public DataStorage(T data){
            this.Data = data;
        }

        public void Display(){
            Console.WriteLine($"Data: {this.Data}");
        }
    }
    
    internal class Program{
        static void Main(string[] args){
            DataStorage<string> ds1 = new DataStorage<string>("Hello");
            DataStorage<int> ds2 = new DataStorage<int>(42);
            DataStorage<double> ds3 = new DataStorage<double>(50.45);
            ds1.Display();
            ds2.Display();
            ds3.Display();
        }
    }
}
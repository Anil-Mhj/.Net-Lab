// Create a class named StudentCollection that stores the names of five students in an array. Implement an Indexer to
// access and modify student names using array-like syntax. Demonstrate adding, retrieving, and updating student names
// through the indexer.

using System;

namespace ConsoleApp20{
    public class StudentCollection{
        public string[] students = new string[5];

        public string this[int index]{
            get { return students[index];}
            set {students[index] = value;}
        }
    }

    class Program{
        static void Main(string[] args){
            StudentCollection sc = new StudentCollection();
            sc[0] = "Alice";
            sc[1] = "Bob";
            sc[2] = "Charlie";
            sc[3] = "David";
            sc[4] = "Eve";
            
            Console.WriteLine(sc[0]);
            Console.WriteLine(sc[1]);
            Console.WriteLine(sc[2]);
            Console.WriteLine(sc[3]);
            Console.WriteLine(sc[4]);
        }
    }
}
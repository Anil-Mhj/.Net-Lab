// Create a program that demonstrates the use of Partial Classes in C#. Divide a class named Student into two separate
// files using the partial keyword. In one file, define the data members Student ID and Student Name, and in the other
// file, implement methods to input and display the student information. Create an object of the class in the Main() method
// and demonstrate that both parts behave as a single class.

using System;

namespace Lab14{
    public partial class Student{
        public int StudentId;
        public string StudentName;
    }

    internal class Program{
        static void Main(string[] args){
            Student s1 = new Student();
            s1.InputDetails();
            s1.Display();
        }
    }
}
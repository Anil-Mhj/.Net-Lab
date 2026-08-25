// Create a Student class with the attributes Student ID, Student Name, and Faculty. Implement both a default
// constructor that initializes the object with predefined values and a parameterized constructor that accepts values
// from the user. Create a Display() method to display all the student information and demonstrate both constructors in
// the Main() method.

using System;

namespace ConsoleApp1{
    public class Student{
        public int StudentId;
        public string Name;
        public string Faculty;

        public Student(){
            this.StudentId = 1;
            this.Name = "John Doe";
            this.Faculty = "Computer Science";
        }

        public Student(int st_id, string name, string faculty){
            this.StudentId = st_id;
            this.Name = name;
            this.Faculty = faculty;
        }

        public void Display(){
            Console.WriteLine($"Student ID: {this.StudentId}");
            Console.WriteLine($"Student Name: {this.Name}");
            Console.WriteLine($"Faculty: {this.Faculty}");
        }
    }
    class Program{
        static void Main(string[] args){
            Student s1 = new Student();
            s1.Display();
            
            Student s2 = new Student(2, "Jane Doe", "Mathematics");
            s2.Display();
        }
    }
}
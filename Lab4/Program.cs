// Develop a College Management System by creating a base class named Person with common attributes such as
// Name and Age. Derive two classes named Student and Teacher from the base class. The Student class should contain
// Roll Number and Faculty, whereas the Teacher class should contain Subject and Salary. Create objects of both
// derived classes and display their complete information.

using System;

namespace Lab4{
    public class Person{
        public string Name;
        public int Age;
    }

    public class Student: Person{
        public int RollNum;
        public string Faculty;

        public Student(string name, int age, int rollNo, string faculty){
            Name = name;
            Age = age;
            RollNum = rollNo;
            Faculty = faculty;
        }

        public void Display(){
            Console.WriteLine("\n---Student Information---");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Roll No.: {this.RollNum}");
            Console.WriteLine($"Faculty: {this.Faculty}");
        }
    }

    public class Teacher: Person{
        public string Subject;
        public double Salary;

        public Teacher(string name, int age, string subject, double salary){
            Name = name;
            Age = age;
            Subject = subject;
            Salary = salary;
        }

        public void Display(){
            Console.WriteLine("\n---Teacher Information---");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Subject: {this.Subject}");
            Console.WriteLine($"Salary: {this.Salary}");
        }
    }

    class Program{
        static void Main(string[] args){
            Student s1 = new Student("Nate", 31, 1, "Computer Science");
            Teacher t1 = new Teacher("Marshall", 45, "Computer", 50000);
            s1.Display();
            t1.Display();
        }
    }
}
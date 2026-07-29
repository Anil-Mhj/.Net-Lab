// Create an interface named IPrintable containing a method called Print(). Implement this interface in two classes named
// Student and Employee. Store appropriate information in each class and use the implemented Print() method to display
// the details of both objects.

using System;

namespace Lab11{
    public interface IPrintable{
        void Print();
    }

    public class Student: IPrintable{
        public int StudentId;
        public string Name;
        public string Faculty;

        public Student(int studentId, string name, string faculty){
            StudentId = studentId;
            Name = name;
            Faculty = faculty;
        }

        public void Print(){
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Faculty: {Faculty}");
        }
    }

    public class Employee: IPrintable{
        public int EmployeeId;
        public string Name;
        public double Salary;

        public Employee(int empId, string name, double salary){
            EmployeeId = empId;
            Name = name;
            Salary = salary;
        }

        public void Print(){
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Program{
        static void Main(string[] args){
            Student stu = new Student(101, "Maisie", "Science");
            Employee emp = new Employee(201, "Lany", 50000);
            stu.Print();
            emp.Print(); 
        }
    }
}
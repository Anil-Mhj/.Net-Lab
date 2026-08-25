// Create a base class Person containing the attributes Name and Address. Derive an Employee class from the Person
// class by adding Employee ID and Salary. Write methods to input and display all employee information by utilizing
// the inherited properties from the base class.

using System;

namespace ConsoleApp3
{
    public class Person
    {
        public string Name;
        public string Address;

        public void InputPersonDetails()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
        }
    }

    public class Employee : Person
    {
        public int EmployeeID;
        public double Salary;

        public void InputEmployeeDetails()
        {
            // Calling inherited method
            InputPersonDetails();

            Console.Write("Enter Employee ID: ");
            EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayEmployeeDetails()
        {
            // Calling inherited method
            DisplayPersonDetails();

            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.InputEmployeeDetails();

            Console.WriteLine("\nEmployee Information:");
            emp.DisplayEmployeeDetails();
        }
    }
}
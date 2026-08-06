// Create a program using the List<T> collection to manage employee information. Allow the user
// to add employee records, display all employees, update an employee's salary, delete an employee
// record, and display the total number of employees stored in the collection.

using System;
using System.Collections.Generic;

namespace Lab26
{
    public class Employee
    {
        public int EmployeeId;
        public string Name;
        public decimal Salary;

        public Employee(int id, string name, decimal salary)
        {
            EmployeeId = id;
            Name = name;
            Salary = salary;
        }
    }

    class Program
    {
        // Display all employees
        static void DisplayEmployees(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employee records found.");
                return;
            }

            foreach (Employee e in employees)
            {
                Console.WriteLine($"ID: {e.EmployeeId}, Name: {e.Name}, Salary: {e.Salary:C}");
            }
        }

        // Add a new employee
        static void AddEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            employees.Add(new Employee(id, name, salary));
            Console.WriteLine("Employee added successfully.");
        }

        // Update an employee's salary
        static void UpdateSalary(List<Employee> employees)
        {
            Console.Write("Enter Employee ID to update salary: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.EmployeeId == id);
            if (emp != null)
            {
                Console.Write("Enter new salary: ");
                emp.Salary = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // Delete an employee
        static void DeleteEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.EmployeeId == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // Display total number of employees
        static void DisplayTotalEmployees(List<Employee> employees)
        {
            Console.WriteLine($"Total number of employees: {employees.Count}");
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Management System =====");
                Console.WriteLine("1. Display Employees");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("3. Update Salary");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Display Total Employees");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayEmployees(employees);
                        break;

                    case 2:
                        AddEmployee(employees);
                        break;

                    case 3:
                        UpdateSalary(employees);
                        break;

                    case 4:
                        DeleteEmployee(employees);
                        break;

                    case 5:
                        DisplayTotalEmployees(employees);
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 6);
        }
    }
}

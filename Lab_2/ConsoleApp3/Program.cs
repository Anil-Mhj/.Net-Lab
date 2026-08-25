// Develop a Student Management System using the generic collection List<T>. Store the details
// of at least five students, including Student ID, Name, and Faculty. Provide functionality to add
// new students, display all student records, search for a student by ID, and remove a student from
// the list.

using System;

namespace ConsoleApp3
{
    public class Student
    {
        public int StudentId;
        public string Name;
        public string Faculty;

        public Student(int id, string name, string faculty)
        {
            StudentId = id;
            Name = name;
            Faculty = faculty;
        }
    }

    class Program
    {
        // Display all students
        static void DisplayStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student records found.");
                return;
            }

            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.StudentId}, Name: {s.Name}, Faculty: {s.Faculty}");
            }
        }

        // Search student by ID
        static void SearchStudent(List<Student> students, int id)
        {
            Student student = students.Find(s => s.StudentId == id);

            if (student != null)
            {
                Console.WriteLine("\nStudent Found");
                Console.WriteLine($"ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Faculty: {student.Faculty}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // Remove student
        static void RemoveStudent(List<Student> students, int id)
        {
            Student student = students.Find(s => s.StudentId == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // Initial five students
            students.Add(new Student(101, "Alice", "BCA"));
            students.Add(new Student(102, "Bob", "BIM"));
            students.Add(new Student(103, "Charlie", "BBS"));
            students.Add(new Student(104, "David", "BSc CSIT"));
            students.Add(new Student(105, "Eva", "BCA"));

            int choice;

            do
            {
                Console.WriteLine("\n===== Student Management System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Remove Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayStudents(students);
                        break;

                    case 2:
                        Console.Write("Enter Student ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Faculty: ");
                        string faculty = Console.ReadLine();

                        students.Add(new Student(id, name, faculty));
                        Console.WriteLine("Student added successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Student ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        SearchStudent(students, searchId);
                        break;

                    case 4:
                        Console.Write("Enter Student ID to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        RemoveStudent(students, removeId);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
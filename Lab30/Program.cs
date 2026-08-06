// Develop a College Management System that demonstrates the use of Generics and
// Collections. Create a generic class to store different types of information, and use collections
// such as List<T>, Dictionary<TKey, TValue>, Queue<T>, and Stack<T> to manage students,
// teachers, library books, admission queues, and recent activities. Implement features to add,
// update, search, delete, and display records while demonstrating the practical use of each
// collection in a single C# Console Application.

using System;
using System.Collections.Generic;

namespace CollegeManagement
{
    class DataStorage<T>
    {
        public T Data;
        public DataStorage(T data)
        {
            Data = data;
        }

        public void Display()
        {
            Console.WriteLine(Data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            Dictionary<int, string> books = new Dictionary<int, string>();
            Queue<string> admissions = new Queue<string>();
            Stack<string> activities = new Stack<string>();

            int choice;

            do
            {
                Console.WriteLine("\n1.Add Student");
                Console.WriteLine("2.Display Students");
                Console.WriteLine("3.Add Book");
                Console.WriteLine("4.Search Book");
                Console.WriteLine("5.Remove Book");
                Console.WriteLine("6.Add Admission");
                Console.WriteLine("7.Serve Admission");
                Console.WriteLine("8.Show Next Admission");
                Console.WriteLine("9.Show Activities");
                Console.WriteLine("10.Generic Demo");
                Console.WriteLine("11.Exit");

                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Student Name: ");
                        string student = Console.ReadLine();
                        students.Add(student);
                        activities.Push("Added Student: " + student);
                        break;

                    case 2:
                        foreach (string s in students)
                            Console.WriteLine(s);
                        break;

                    case 3:
                        Console.Write("Book ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Book Title: ");
                        string title = Console.ReadLine();

                        books[id] = title;
                        activities.Push("Added Book: " + title);
                        break;

                    case 4:
                        Console.Write("Book ID: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (books.ContainsKey(id))
                            Console.WriteLine(books[id]);
                        else
                            Console.WriteLine("Book not found.");
                        break;

                    case 5:
                        Console.Write("Book ID: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (books.Remove(id))
                            Console.WriteLine("Book removed.");
                        else
                            Console.WriteLine("Book not found.");
                        break;

                    case 6:
                        Console.Write("Student Name: ");
                        string name = Console.ReadLine();

                        admissions.Enqueue(name);
                        activities.Push("Admission: " + name);
                        break;

                    case 7:
                        if (admissions.Count > 0)
                            Console.WriteLine("Served: " + admissions.Dequeue());
                        else
                            Console.WriteLine("Queue Empty");
                        break;

                    case 8:
                        if (admissions.Count > 0)
                            Console.WriteLine("Next: " + admissions.Peek());
                        else
                            Console.WriteLine("Queue Empty");
                        break;

                    case 9:
                        foreach (string activity in activities)
                            Console.WriteLine(activity);
                        break;

                    case 10:
                        DataStorage<int> n = new DataStorage<int>(100);
                        DataStorage<string> t = new DataStorage<string>("Hello");
                        n.Display();
                        t.Display();
                        break;

                    case 11:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 11);
        }
    }
}
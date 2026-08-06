// Develop a Hospital Token Management System using the Queue<T> collection. Add patients
// to the queue as they arrive, display the current waiting list, serve patients in the order they
// entered the queue, and display the next patient to be served.

using System;

namespace Lab28
{
    class Program
    {
        static void DisplayPatients(Queue<string> patients)
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients in the queue.");
                return;
            }

            Console.WriteLine("\nCurrent Waiting List:");
            foreach (string patient in patients)
            {
                Console.WriteLine(patient);
            }
        }

        static void AddPatient(Queue<string> patients)
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            patients.Enqueue(name);

            Console.WriteLine("Patient added successfully.");
        }

        static void ServePatient(Queue<string> patients)
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients to serve.");
                return;
            }

            string servedPatient = patients.Dequeue();

            Console.WriteLine($"Patient Served: {servedPatient}");
        }

        static void NextPatient(Queue<string> patients)
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients waiting.");
                return;
            }

            Console.WriteLine($"Next Patient: {patients.Peek()}");
        }

        static void Main(string[] args)
        {
            Queue<string> patients = new Queue<string>();

            int choice;

            do
            {
                Console.WriteLine("\n===== Hospital Token Management System =====");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Display Waiting List");
                Console.WriteLine("3. Serve Patient");
                Console.WriteLine("4. Display Next Patient");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPatient(patients);
                        break;

                    case 2:
                        DisplayPatients(patients);
                        break;

                    case 3:
                        ServePatient(patients);
                        break;

                    case 4:
                        NextPatient(patients);
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
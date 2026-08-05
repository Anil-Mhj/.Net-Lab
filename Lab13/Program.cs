// Develop a Hospital Management System that demonstrates the concepts of Constructors, Inheritance, Method
// Overloading, Method Overriding, Abstract Classes, and Interfaces. Create an abstract class named Hospital,
// derive Doctor and SpecialistDoctor classes from it, and implement an interface named IAppointment containing
// methods for booking and canceling appointments. Overload the CalculateBill() method to calculate different types of
// bills and override the DisplayDetails() method to display doctor information. Create appropriate objects to demonstrate
// all the required object-oriented programming concepts in a single application.

using System;

namespace HospitalManagementSystem
{
    // Interface
    interface IAppointment
    {
        void BookAppointment();
        void CancelAppointment();
    }

    // Abstract Class
    abstract class Hospital
    {
        public string DoctorName;
        public string Department;

        // Constructor
        public Hospital(string doctorName, string department)
        {
            DoctorName = doctorName;
            Department = department;
        }

        // Method Overloading
        public double CalculateBill(double consultationFee)
        {
            return consultationFee;
        }

        public double CalculateBill(double consultationFee, double medicineCharge)
        {
            return consultationFee + medicineCharge;
        }

        // Abstract Method
        public abstract void DisplayDetails();
    }

    // Derived Class
    class Doctor : Hospital, IAppointment
    {
        public Doctor(string doctorName, string department)
            : base(doctorName, department)
        {
        }

        public void BookAppointment()
        {
            Console.WriteLine("Appointment Booked Successfully.");
        }

        public void CancelAppointment()
        {
            Console.WriteLine("Appointment Cancelled.");
        }

        // Method Overriding
        public override void DisplayDetails()
        {
            Console.WriteLine("----- Doctor Details -----");
            Console.WriteLine("Doctor Name : " + DoctorName);
            Console.WriteLine("Department  : " + Department);
        }
    }

    // Derived Class
    class SpecialistDoctor : Doctor
    {
        public string Specialization;

        public SpecialistDoctor(string doctorName, string department, string specialization)
            : base(doctorName, department)
        {
            Specialization = specialization;
        }

        // Method Overriding
        public override void DisplayDetails()
        {
            Console.WriteLine("----- Specialist Doctor Details -----");
            Console.WriteLine("Doctor Name    : " + DoctorName);
            Console.WriteLine("Department     : " + Department);
            Console.WriteLine("Specialization : " + Specialization);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Doctor Object
            Doctor d1 = new Doctor("Dr. Ram", "General Medicine");

            d1.DisplayDetails();
            d1.BookAppointment();

            Console.WriteLine("Consultation Bill : " + d1.CalculateBill(500));

            Console.WriteLine("Total Bill        : " +
                d1.CalculateBill(500, 1200));

            Console.WriteLine();

            // Specialist Doctor Object
            SpecialistDoctor s1 = new SpecialistDoctor(
                "Dr. Hari",
                "Cardiology",
                "Heart Specialist");

            s1.DisplayDetails();
            s1.BookAppointment();
            s1.CancelAppointment();

            Console.WriteLine("Consultation Bill : " +
                s1.CalculateBill(1000));

            Console.WriteLine("Total Bill        : " +
                s1.CalculateBill(1000, 2500));
        }
    }
}
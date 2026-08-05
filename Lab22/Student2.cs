using System;

namespace StudentManagement{
    public partial class Student{
        public int Total;
        public double Percentage;
        public string Grade;

        public void Show(){
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total: {Total}");
            Console.WriteLine($"Percentage: {Percentage:F2}%");
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
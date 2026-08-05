// Create a Student Result Processing System using delegates. Define separate methods to calculate the Total Marks,
// Percentage, and Grade of a student. Use delegates to invoke these methods and display the complete result of the
// student.

using System;

namespace Lab18
{
    class Student
    {
        public string Name;
        public int[] Marks;

        public Student(string name, int[] marks)
        {
            Name = name;
            Marks = marks;
        }

        public int CalculateTotal()
        {
            int total = 0;

            foreach (int mark in Marks)
            {
                total += mark;
            }

            return total;
        }

        public double CalculatePercentage(int total)
        {
            return (double)total / (Marks.Length * 100) * 100;
        }

        public string CalculateGrade(double percentage)
        {
            if (percentage >= 80)
                return "A";
            else if (percentage >= 60)
                return "B";
            else if (percentage >= 40)
                return "C";
            else
                return "Fail";
        }
    }

    class Program
    {
        public delegate int TotalDelegate();
        public delegate double PercentageDelegate(int total);
        public delegate string GradeDelegate(double percentage);

        static void Main(string[] args)
        {
            Student student = new Student(
                "John",
                new int[] { 85, 90, 78, 88, 92, 80 }
            );
            TotalDelegate totalDelegate = student.CalculateTotal;
            PercentageDelegate percentageDelegate = student.CalculatePercentage;
            GradeDelegate gradeDelegate = student.CalculateGrade;
            int total = totalDelegate();
            double percentage = percentageDelegate(total);
            string grade = gradeDelegate(percentage);
            Console.WriteLine("--- Student Result ---");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage}%");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
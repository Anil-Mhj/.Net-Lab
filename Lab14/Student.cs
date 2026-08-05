namespace Lab14{
    public partial class Student{
        public void InputDetails(){
            Console.Write("Enter the student ID:");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the student name:");
            StudentName = Console.ReadLine();
        }

        public void Display(){
            Console.WriteLine($"The student ID is {this.StudentId}");
            Console.WriteLine($"The student name is {this.StudentName}");
        }
    }
}
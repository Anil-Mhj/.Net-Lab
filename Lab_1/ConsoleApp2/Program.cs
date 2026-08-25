// Create a Rectangle class with Length and Width as data members. Implement a default constructor and a
// parameterized constructor to initialize the object. Write methods to calculate the Area and Perimeter of the rectangle
// and display the calculated values using a separate display method.

using System;

namespace ConsoleApp2{
    public class Rectangle{
        public double Length;
        public double Width;

        public Rectangle(){
            Length = 5;
            Width = 4;
        }

        public Rectangle(double length, double width){
            Length = length;
            Width = width;
        }

        public double Area(){
            return Length * Width;
        }

        public double Perimeter(){
            return 2 * (Length + Width);
        }

        public void Display(){
            Console.WriteLine($"Area of rectangle is {this.Area()}");
            Console.WriteLine($"Perimater of rectangle is {this.Perimeter()}");
        }
    }

    class Program {
        static void Main(string[] args){
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(8.0, 9.0);
            r1.Display();
            r2.Display();
        }
    }
}
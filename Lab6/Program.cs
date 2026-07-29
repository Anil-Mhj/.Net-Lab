// Create a class named AreaCalculator and overload the Area() method to calculate the area of a Circle, Rectangle,
// and Triangle by accepting different sets of parameters. Display the calculated area for each shape using appropriate
// method calls.

using System;

namespace Lab6{
    public class AreaCalculator{
        const double PI = 3.14;

        public double Area(int radius){
            return PI * radius * radius;
        }

        public double Area(int length, int width){
            return length * width;
        }

        public double Area(double baseValue, double height){
            return 0.5 * baseValue * height;
        }
    }

    class Program{
        static void Main(string[] args){
            AreaCalculator ac = new AreaCalculator();
            Console.WriteLine($"Area of circle: {ac.Area(5)}");
            Console.WriteLine($"Area of rectangle: {ac.Area(5, 8)}");
            Console.WriteLine($"Area of triangle: {ac.Area(5.0, 6.0)}");
        }
    }
}
// Create a base class named Shape with a virtual method called Draw(). Derive the classes Circle, Rectangle, and
// Triangle, and override the Draw() method in each class to display an appropriate message indicating which shape is
// being drawn. Demonstrate method overriding by invoking the method using base class references.

using System;

namespace Lab8
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape!");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle!");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle!");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;

            shape = new Circle();
            shape.Draw();

            shape = new Rectangle();
            shape.Draw();

            shape = new Triangle();
            shape.Draw();
        }
    }
}
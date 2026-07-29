// Create a base class named Animal containing a virtual method called MakeSound(). Derive three classes named Dog,
// Cat, and Cow from the Animal class and override the MakeSound() method in each class to display the appropriate
// sound of each animal. Demonstrate runtime polymorphism by calling the overridden methods through a base class
// reference.

using System;

namespace Lab7{
    public class Animal{
        public virtual void MakeSound(){
            Console.WriteLine("Animal making sound!");
        }

    }

    public class Dog: Animal{
        public override void MakeSound(){
            Console.WriteLine("Dog barks!");
        }
    }
    public class Cat: Animal{
        public override  void MakeSound(){
            Console.WriteLine("Cat meows!");
        }
    }
    public class Cow: Animal{
        public override void MakeSound(){
            Console.WriteLine("Cow moos!");
        }
    }

    class Program{
        static void Main(string[] args)
        {
            Animal animal;

            animal = new Dog();
            animal.MakeSound();

            animal = new Cat();
            animal.MakeSound();

            animal = new Cow();
            animal.MakeSound();
        }
    }
}
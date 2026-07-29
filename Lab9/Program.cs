// Create an abstract class named Vehicle containing the attributes Vehicle Number and Brand, along with an abstract
// method named Start(). Create derived classes named Car and Bike that implement the Start() method. Instantiate the
// derived classes and display their respective start messages.

using System;

namespace Lab9
{
    public abstract class Vehicle
    {
        public string VehicleNumber;
        public string Brand;

        public abstract void Start();
    }

    public class Car : Vehicle
    {
        public Car(string vehicleNumber, string brand)
        {
            VehicleNumber = vehicleNumber;
            Brand = brand;
        }

        public override void Start()
        {
            Console.WriteLine($"Car {Brand} with Vehicle Number {VehicleNumber} starts with a key ignition.");
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string vehicleNumber, string brand)
        {
            VehicleNumber = vehicleNumber;
            Brand = brand;
        }

        public override void Start()
        {
            Console.WriteLine($"Bike {Brand} with Vehicle Number {VehicleNumber} starts with a self-start button.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BA-1234", "Toyota");
            Bike bike = new Bike("BA-5678", "Honda");

            car.Start();
            bike.Start();
        }
    }
}
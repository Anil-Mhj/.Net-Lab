// Create two interfaces named ICamera and IMusicPlayer, where the first interface contains the method TakePhoto()
// and the second contains the method PlayMusic(). Implement both interfaces in a class named SmartPhone and
// demonstrate multiple interface implementation by calling both methods from the Main() method.

using System;

namespace ConsoleApp12{
    public interface ICamera{
        void TakePhoto();
    }

    public interface IMusicPlayer{
        void PlayMusic();
    }

    public class SmartPhone: ICamera, IMusicPlayer{
        public string Name;
        public string Brand;
        public double Price;

        public SmartPhone(string name, string brand, double price){
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        public void DisplayDetails(){
            Console.WriteLine("Phone Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: {Price}");
        }

        public void TakePhoto(){
            Console.WriteLine("Taking Photo...");
        }

        public void PlayMusic(){
            Console.WriteLine("Playing Music...");
        }
    }

    class Program{
        static void Main(string[] args){
            SmartPhone phone = new SmartPhone("Galaxy S25", "Samsung", 999.99);
            phone.DisplayDetails();
            phone.TakePhoto();
            phone.PlayMusic();
        }
    }
}
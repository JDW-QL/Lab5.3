using System;
using ClassLibrary;

namespace Lab5._3BE
{
    class Program
    {
        static void UserSellCarValidate()
        {
            Console.Clear();
            Console.Write("Please enter the Make: ");
            string make = Console.ReadLine();
            Console.Write("Please enter the Model: ");
            string model = Console.ReadLine();
            Console.Write("Please enter the Year: ");
            _ = int.TryParse(Console.ReadLine(), out int tempInt);
            int year = tempInt;
            Console.Write("Please enter the Price: ");
            _ = double.TryParse(Console.ReadLine(), out double tempDouble);
            double price = tempDouble;
            Console.Write("Please enter the Mileage: ");
            _ = double.TryParse(Console.ReadLine(), out tempDouble);
            double mileage = tempDouble;
            CarLot.AddCar(new UsedCar(make, model, year, price, mileage));
        }
        static void UserBuyCarValidate(int choice)
        {
            Console.Write("\nWould you like to buy " + CarLot.Cars[choice-1] + "?\n(y/n): ");
            if (Console.ReadLine().ToLower() == "y") 
            {
                Console.WriteLine(CarLot.Cars[choice - 1] + " has been sold.\n");
                CarLot.RemoveCar(CarLot.Cars[choice - 1]); 
            }
            else 
                Console.WriteLine(CarLot.Cars[choice - 1] + "has not been sold."); 
        }
        static bool MainMenu()
        {
            CarLot.DisplayCarInventory();
            int choice = 0;
            bool fPass = true;
            Console.Write($"Please select a car to purchase\n({CarLot.Cars.Count+1}) to sell a car\n({CarLot.Cars.Count+2}) to Quit:  ");
            while (choice < 1 || choice > CarLot.Cars.Count + 2)
            {
                if (fPass == false) { Console.WriteLine($"Please enter a valid number between 1 and {CarLot.Cars.Count + 2}."); }
                _= Int32.TryParse(Console.ReadLine(), out choice);
                fPass = false;
            }
            if (choice < CarLot.Cars.Count + 1) { UserBuyCarValidate(choice); }
            else if (choice == CarLot.Cars.Count + 1) { UserSellCarValidate(); }
            else { return false; }
            return true;
        }
        static void SetInnitialCarList()
        {
            CarLot.AddCar(new Car("Nikola", "Model S", 2021, 54999.90d));
            CarLot.AddCar(new Car("Fourd", "Escapade", 2021, 31999.90d));
            CarLot.AddCar(new Car("Chewie", "Vette", 2021, 44989.95d));
            CarLot.AddCar(new UsedCar("Hyonda", "Prior", 2015, 14795.50d, 35987.6d));
            CarLot.AddCar(new UsedCar("GC", "Chirpus", 2013, 8500.00d, 12345.0d));
            CarLot.AddCar(new UsedCar("GC", "Witherell", 2016, 14450.00d, 3500.3d));
        }
        static void Main(string[] args)
        {
            SetInnitialCarList(); 
            do 
            { 
                Console.Clear(); 
            } while (MainMenu());
        }
    }
}

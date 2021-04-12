using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class CarLot
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
        public static void AddCar(Car car) { Cars.Add(car); }
        public static void RemoveCar(Car car) { Cars.Remove(car); }
        public static void DisplayCarInventory()
        {
            Console.WriteLine("Welcome to the car lot!\n");
            for (int i = 1; i <= CarLot.Cars.Count; i++)
            {
                Console.WriteLine($"{i}. {CarLot.Cars[i - 1]}");
            }
            Console.WriteLine();
        }
    }
}

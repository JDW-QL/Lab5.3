using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car
    {
        public Car(){}
        public string Make { get; set; } = "Unknown";
        public string Model { get; set; } = "Unknown";
        public int Year { get; set; } = 0;
        public double Price { get; set; } = 0.00d;
        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public override string ToString()
        {
            return (String.Format("Make : {0,-8} Model: {1,-10} Year: {2,-5} Price: {3,10:C2}", Make, Model, Year, Price));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UsedCar : Car
    {
        public UsedCar(){}
        public double Mileage {get; set;} = 0.00d;
        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price) {Mileage = mileage;}
        public override string ToString()
        {
            return (String.Format("Make : {0,-8} Model: {1,-10} Year: {2,-5} Price: {3,10:C2}   Mileage: {4,8:0.00}", Make, Model, Year, Price, Mileage));
        }
    }
}

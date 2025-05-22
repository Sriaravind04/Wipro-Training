using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class Vehicle {
        public string VehicleNumber { get; set; }
        public string Brand {  get; set; }
        public decimal RatePerDay { get; set; }

        public virtual decimal CalculateRent(int days) {
            return RatePerDay * days;
        }

    }
    class Car : Vehicle {

        public override decimal CalculateRent(int days)
        {
            decimal baseRent = base.CalculateRent(days);
            decimal surcharge = 200;
            return baseRent + surcharge;
        }
    }
    class Bike : Vehicle {
        public override decimal CalculateRent(int days) {
            decimal baserent = base.CalculateRent(days);
            decimal surcharge = 50;
            return baserent + surcharge;
        }
    }
    class Truck : Vehicle {
        public override decimal CalculateRent(int days) {
            decimal baseRent = base.CalculateRent(days);
            decimal heavyDutyCharge = 500;
            return baseRent + heavyDutyCharge;
        }
    }
    class Program13
    {
        static void Main() { 
            List<Vehicle> vehicle = new List<Vehicle> { 
                new Car {VehicleNumber = "TN01CAR123", Brand = "Toyota", RatePerDay = 1500},
                new Bike{VehicleNumber = "TN02BIKE456", Brand = "Yamaha", RatePerDay = 500},
                new Truck{VehicleNumber = "TN03TRUCK789", Brand = "Tata", RatePerDay= 3000}
            };

            int rentalDays = 3;

            Console.WriteLine($"Rent for {rentalDays} days:");
            foreach (var v in vehicle) { 
                decimal rent = v.CalculateRent(rentalDays);
                Console.WriteLine($"{v.GetType().Name} ({v.VehicleNumber}, {v.Brand}) : Rs{rent}");
            }
        }
    }
}
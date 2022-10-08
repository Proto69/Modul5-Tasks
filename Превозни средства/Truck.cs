using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Превозни_средства
{
    public class Truck : IMachine
    {
        public double Fuel { get; protected set; }

        public double Consumption { get; protected set; }

        public Truck(double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption + 1.6;
        }

        public void Drive(double kilometer)
        {
            double neededFuel = kilometer * this.Consumption;
            if (neededFuel > this.Fuel)
            {
                Console.WriteLine("Truck needs refueling");
                return;
            }
            this.Fuel -= neededFuel;
            Console.WriteLine($"Truck travelled {kilometer} km");
        }

        public void Refuel(double liter)
        {
            this.Fuel += (liter * 95) / 100;
        }

        public override string ToString()
        {
            return $"Truck: {this.Fuel:F2}";
        }
    }
}

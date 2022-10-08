using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Превозни_средства
{
    public class Car : IMachine
    {
        public double Fuel { get; protected set; }

        public double Consumption { get; protected set; }

        public Car(double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption + 0.9;
        }

        public void Drive(double kilometer)
        {
            double neededFuel = kilometer * this.Consumption;
            if (neededFuel > this.Fuel)
            {
                Console.WriteLine("Car needs refueling");
                return;
            }
            this.Fuel -= neededFuel;
            Console.WriteLine($"Car travelled {kilometer} km");
        }

        public void Refuel(double liter)
        {
            this.Fuel += liter ;
        }

        public override string ToString()
        {
            return $"Car: {this.Fuel:F2}";
        }
    }
}

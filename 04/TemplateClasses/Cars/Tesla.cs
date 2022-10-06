using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateClasses.Interfaces;

namespace TemplateClasses.Cars
{
    internal class Tesla : IElectricCar
    {
        public int Batteries { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Batteries = batteries;
        }


        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Batteries} Batteries";
        }

        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }
    }
}

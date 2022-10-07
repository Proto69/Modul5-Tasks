using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигури
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            double result = Radius * Radius * Math.PI;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = 2 * Math.PI * Radius;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигури
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Wide { get; set; }

        public Rectangle(double length, double wide)
        {
            this.Length = length;
            this.Wide = wide;
        }

        public override double CalculateArea()
        {
            double result = Length * Wide;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = Length * 2 + Wide * 2;
            return result;
        }

        public new string Draw()
        {
            //Пример мързи ме да го мисля
            return base.Draw();
        }
    }
}

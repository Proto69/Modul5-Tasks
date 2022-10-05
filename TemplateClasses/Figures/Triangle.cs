using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateClasses.Interfaces;

namespace TemplateClasses.Figures
{
    internal class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size)
        { }

        public override double GetArea()
        {
            return (Size * Size * Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            return "Triangle";
        }

        public override string ToString()
        {
            return Show();
        }
    }
}

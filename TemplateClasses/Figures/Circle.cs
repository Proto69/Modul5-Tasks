using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.Figures
{
    internal class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Size * Size;
        }

        public override string GetName()
        {
            return "Circle";
        }

        public override string ToString()
        {
            return Show();
        }
    }
}

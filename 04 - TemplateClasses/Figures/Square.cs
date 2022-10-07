using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.Figures
{
    internal class Square : ColoredFigure
    {
        public Square(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Size * Size;
        }

        public override string GetName()
        {
            return "Square";
        }

        public override string ToString()
        {
            return Show();
        }
    }
}

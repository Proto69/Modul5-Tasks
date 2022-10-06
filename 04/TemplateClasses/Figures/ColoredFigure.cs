using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.Figures
{
    public abstract class ColoredFigure
    {
        public string Color { get; set; }
        public double Size { get; set; }

        public ColoredFigure(string color, double size)
        {
            Color = color;
            Size = size;
        }

        public string Show()
        {
            return $"{GetName()}: \nColor: {Color} \nSize: {Size} \nArea: {GetArea():F2}";
        }
        public abstract string GetName();
        public abstract double GetArea();
    }
}

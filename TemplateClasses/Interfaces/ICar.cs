using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.Interfaces
{
    internal interface ICar
    {
        string Model { get; protected set; }
        string Color { get; protected set; }

        string Start();
        string Stop();
        string ToString();
    }
}

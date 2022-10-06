using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.Interfaces
{
    internal interface IElectricCar : ICar
    {
        int Batteries { get; protected set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Превозни_средства
{
    public interface IMachine
    {
        double Fuel { get; }
        double Consumption { get; }

        void Drive(double kilometer);
        void Refuel(double liter);
    }
}

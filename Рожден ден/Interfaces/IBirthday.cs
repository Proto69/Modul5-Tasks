using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рожден_ден.Interfaces
{
    public interface IBirthday
    {
        string Birthday { get; }

        bool CheckYear(string year);
    }
}

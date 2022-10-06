using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Недостиг_на_храна
{
    public interface IBuyer
    {
        int Food { get; }

        void BuyFood();
    }
}

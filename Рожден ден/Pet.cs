using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class Pet : IBirthday
    {
        public string Birthday { get; }

        public bool CheckYear(string year)
        {
            string birthdayYear = Birthday.Substring(Birthday.Length - 4);
            if (birthdayYear == year)
                return true;
            return false;
        }
    }
}

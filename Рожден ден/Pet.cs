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
        public string Name { get; set; }
        public string Birthday { get; }

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string GetBirthDay()
        {
            return Birthday;
        }
    }
}

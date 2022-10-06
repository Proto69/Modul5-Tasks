using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class Citizen : IID, IBirthday
    {
        public string Name { get; }
        public int Age { get; }
        public long ID { get; }
        public string Birthday { get; }

        public Citizen(string name, int age, long id, string birthday)
        {
            Name = name;
            Age = age;
            ID = id;
            this.Birthday = birthday;
        }

        public long GetID()
        {
            return ID;
        }

        public string GetBirthDay()
        {
            return Birthday;
        }
    }
}

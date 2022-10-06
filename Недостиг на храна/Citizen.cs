using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Недостиг_на_храна.Interfaces;

namespace Недостиг_на_храна
{
    public class Citizen : IID, IBirthday, IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public long ID { get; }
        public string Birthday { get; }
        public int Food { get; private set; }

        public Citizen(string name, int age, long id, string birthday)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthday = birthday;
            Food = 0;
        }

        public long GetID()
        {
            return ID;
        }

        public string GetBirthDay()
        {
            return Birthday;
        }

        public int BuyFood()
        {
            this.Food += 10;
            return 10;
        }
    }
}

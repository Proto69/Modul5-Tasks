using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class Human : IID
    {
        public string Name { get; }
        public int Age { get; }
        public long ID { get; }

        public Human(string name, int age, long iD)
        {
            Name = name;
            Age = age;
            ID = iD;
        }

        public long GetID()
        {
            return ID;
        }
    }
}

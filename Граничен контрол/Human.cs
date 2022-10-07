using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Граничен_контрол
{
    public class Human : IDs
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клиника_за_домашни_любимци
{
    public class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Type { get; set; }

        public Pet(string name, int age, string type)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Type}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сравняване_на_обекти
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            string name = other.Name;
            int age = other.Age;
            string town = other.Town;
            if (name == this.Name && age == this.Age && town == this.Town)
                return 0;
            else
                return 1;
        }
    }
}

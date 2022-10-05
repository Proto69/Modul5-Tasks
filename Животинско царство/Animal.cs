using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Животинско_царство
{
    public abstract class Animal : IMakeNoise, IMakeTrick
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void MakeNoise()
        {
            Console.WriteLine($"My name is {this.Name}. I am {this.Age} old.");
        }

        public void MakeTrick()
        {
            Console.WriteLine($"Look at my trick!");
        }
    }
}

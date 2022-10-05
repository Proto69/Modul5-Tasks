using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Животинско_царство
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public new void MakeNoise()
        {
            Console.WriteLine("Meow!");
            base.MakeNoise();
        }

        public new void MakeTrick()
        {
            Console.WriteLine($"No trick for you! I'm too lazy!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Животинско_царство
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public new void MakeNoise()
        {
            Console.WriteLine("Woof!");
            base.MakeNoise();
        }
        public new void MakeTrick()
        {
            Console.WriteLine("Hold my paw, human!");
        }
    }
}

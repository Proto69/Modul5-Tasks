using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.DataStorage
{
    internal class RandomList<T> : List<T>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public T RandomItem()
        {
            T item = base[random.Next(Count)];
            Remove(item);
            return item;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.DataStorage
{
    public class Box<T> where T : IComparable<T>
    {
        public T Data { get; set; }

        public void Add(T item)
        {
            Data = item;
        }

        public static int CountOfItems(List<Box<T>> list, Box<T> item)
        {
            int count = 0;
            foreach (var thing in list)
            {
                if (thing.Data.CompareTo(item.Data) > 0)
                    count++;
            }
            return count;
        }

        public override string ToString()
        {
            return $"{Data.GetType().FullName}: {Data}";
        }
    }
}

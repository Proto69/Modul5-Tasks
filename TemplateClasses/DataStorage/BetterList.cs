using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.DataStorage
{
    internal class BetterList<T> : IEnumerable<T>
        where T : IComparable
    {
        public List<T> Data { get; private set; }

        public BetterList()
        {
            Data = new List<T>();
        }

        public void Add(T item)
        {
            Data.Add(item);
        }

        public T Remove(int index)
        {
            T item = Data[index];
            Data.RemoveAt(index);
            return item;
        }
        public bool Contains(T item)
        {
            return Data.Contains(item);
        }
        public void Swap(int index1, int index2)
        {
            T item = Data[index1];
            Data[index1] = Data[index2];
            Data[index2] = item;
        }
        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var item in Data)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Max()
        {
            T max = Data[0];
            foreach (var item in Data)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public T Min()
        {
            T min = Data[0];
            foreach (var item in Data)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public string Print()
        {
            string a = string.Join("\n", Data);
            return a;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

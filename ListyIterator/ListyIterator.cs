using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        public List<T> List { get; set; }
        public int Index { get; set; }

        public ListyIterator(List<T> list)
        {
            this.List = list;
            this.Index = 0;
        }
        public ListyIterator() : this(new List<T>())
        {
        }

        public bool Move()
        {
            Index++;
            return HasNext();
        }
        public bool HasNext()
        {
            if (Index >= List.Count)
                return false;
            return true;
        }
        public void Print()
        {
            if (List.Count == 0 || !HasNext())
                throw new ArgumentException("Invalid operation!");
            Console.WriteLine(List[Index]);
        }
    }
}

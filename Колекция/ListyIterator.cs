using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
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
            CheckIfEmpty();
            Console.WriteLine(List[Index]);
        }
        public void PrintAll()
        {
            CheckIfEmpty();
            string result = "";
            foreach (var item in List)
            {
                result += $"{item} ";
            }
            Console.WriteLine(result);
        }

        private bool CheckIfEmpty()
        {
            if (List.Count == 0 || !HasNext())
                throw new ArgumentException("Invalid operation!");
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < List.Count; i++)
            {
                yield return List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

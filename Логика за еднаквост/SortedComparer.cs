using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Логика_за_еднаквост
{
    public class SortedComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age == y.Age && x.Name.ToLower() == y.Name.ToLower())
                return 0;
            return 1;
        }
    }
}

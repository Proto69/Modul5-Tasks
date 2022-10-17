using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблон_Strategy
{
    internal class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length > y.Name.Length)
                return 1;
            else if (x.Name.Length < y.Name.Length)
                return -1;
            else
            {
                if (x.Name.ToLower()[0] > y.Name.ToLower()[0])
                    return 1;
                else if (x.Name.ToLower()[0] < y.Name.ToLower()[0])
                    return -1;
            }
            return 0;
        }
    }
}

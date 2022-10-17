using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Логика_за_еднаквост
{
    public class HashComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x.Name.ToLower() == y.Name.ToLower() && x.Age == y.Age)
                return true;
            return false;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            int hCode = obj.Age / obj.Name.Length;
            return obj.Name.GetHashCode();
        }
    }
}

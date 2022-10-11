using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROG
{
    internal class Lake : IEnumerable<int>
    {
        public List<int> List { get; set; }
        private int index;

        public Lake(List<int> list)
        {
            List = list;
            this.index = 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return List[i];
                }
            }
            for (int i = List.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return List[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

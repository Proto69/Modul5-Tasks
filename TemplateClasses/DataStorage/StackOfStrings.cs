using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.DataStorage
{
    internal class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new();
        }

        public void Push(string item)
        {
            data.Add(item);
        }
        public string Pop()
        {
            string a = data[0];
            data.RemoveAt(0);
            return a;
        }
        public string Peek()
        {
            return data[0];
        }
        public bool IsEmpty()
        {
            if (data.Count == 0)
                return true;
            else
                return false;
        }
    }
}

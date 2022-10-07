using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClasses.DataStorage
{
    internal class Scale<T> where T : IComparable
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T? GetHeavier()
        {
            return Left.CompareTo(Right) switch
            {
                1 => Left,
                -1 => Right,
                _ => default,
            };
        }
    }
}

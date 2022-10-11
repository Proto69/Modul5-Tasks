﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> list;

        public MyStack()
        {
            this.list = new();
        }

        public void Push(List<T> items)
        {
            foreach (var item in items)
            {
                list.Add(item);
            }
        }
        public T Pop()
        {
            if (list.Count == 0)
                throw new IndexOutOfRangeException("The stack is empty!");
            T item = list[list.Count - 1];
            list.Remove(item);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0 ; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

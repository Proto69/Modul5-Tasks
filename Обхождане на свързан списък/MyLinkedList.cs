using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Обхождане_на_свързан_списък
{
    public class MyLinkedList<T> : IEnumerable
        where T : IComparable
    {
        class Node
        {
            public T Value { get; set; }
            public Node NextNode { get; set; }
            public Node(T value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{this.Value} ";
            }
        }

        private Node head;
        private Node tail;
        private Node currentNode;
        public int Count { get; protected set; }

        public void Add(T value)
        {
            Node node = new(value);
            if (head == null)
            {
                head = node;
                currentNode = head;
                tail = node;
            }
            else
            {
                currentNode.NextNode = node;
                tail = node;
                currentNode = node;
            }
            Count++;
        }
        public bool Remove(T value)
        {
            Node currentNode = head;
            Node prevNode = head;
            while (true)
            {
                if (currentNode == null) return false;
                if (currentNode.Value.Equals(value)) break;
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            if (currentNode == head) head = head.NextNode;
            else if (currentNode == tail) tail = prevNode;
            else prevNode.NextNode = currentNode.NextNode;
            Count--;
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            Node now = head;
            for (int i = 0; i < Count; i++)
            {
                yield return now;
                now = now.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

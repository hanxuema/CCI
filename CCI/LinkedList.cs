using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }

    }

    public class LinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        public int Count { get; private set; }

        public bool IsReadOnly { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            //if there is a head
            var temp = Head;
            node.Next = temp;
            Head = node;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                var temp = Tail;
                Tail = node;
                temp.Next = Tail;
            }

            Count++;
            if (Count == 1)
            {
                Head = Tail;
            }
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            Tail = null;

            if (Count == 1)
            {
                Head = null;
            }
            Count--;
        }

        public void PrintList(Node node)
        {
            while (node != null)
            {

            }
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

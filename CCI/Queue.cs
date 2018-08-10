using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI
{
    public class Queue<T>
    {
        private QueueNode<T> first;
        private QueueNode<T> last;
        public void Add(T item)
        {
            var newNode = new QueueNode<T>(item);
            if (isEmpty())
            {
                last = newNode;
                first = last;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }

        //remove the first node
        public void Remove()
        {
            if (first == null)
            {
                throw new Exception();
            }
            if (first.next != null)
            {
                first.next = first;
            }
            first = null;
        }

        //return the top one
        public QueueNode<T> Peek()
        {
            if (isEmpty())
            {
                throw new Exception();
            }
            else
            {
                return last;
            }
        }

        public bool isEmpty()
        {
            if (first == null)
            {
                return true;
            }
            return false;
        }
    }
    public class QueueNode<T>
    {
        public T data;
        public QueueNode<T> pre;
        public QueueNode<T> next;
        public QueueNode(T data)
        {
            this.data = data;
        }
    }
}

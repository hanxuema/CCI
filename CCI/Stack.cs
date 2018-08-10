using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI
{
    public class StackNode<T>
    {
        public T data;
        public StackNode<T> pre;
        public StackNode(T data)
        {
            this.data = data;
        }
    }
    public class Stack<T>
    {
        private StackNode<T> top;
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            else
            {
                T item = top.data;
                top = top.pre;
                return item;
            }
        }

        public void Push(T item)
        {
            var node = new StackNode<T>(item);
            node.pre = top;
            top = node;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            else
            {
                return top.data;
            }
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }
    }

    public class StackWithMin : Stack<int>
    {
        private StackNode<int> min;
         
    }
}

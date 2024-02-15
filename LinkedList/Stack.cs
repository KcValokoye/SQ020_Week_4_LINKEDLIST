using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Stack<T>
    {
        private Node<T> top;
        private int count;

        public int Push(T item)
        {
            var newNode = new Node<T> { Tvalue = item };
            newNode.NextNode = top;
            top = newNode;
            count++;
            return count;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = top.Tvalue;
            top = top.NextNode;
            count--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Tvalue;
        }

        public int Size()
        {
            return count;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
    }

}


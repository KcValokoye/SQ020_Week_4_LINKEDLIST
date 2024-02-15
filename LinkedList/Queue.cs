using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   
 
    public class Queue<T> : Node<T>
    {
        private int QueueSize;
        public void Enqueue(T item)
        {
            var newNode = new Node<T> { Tvalue = item };
            if (NodeTail == null)
            {
                NodeHead = newNode;
                NodeTail = newNode;
            }
            else
            {

                NodeTail.NextNode = newNode;
                NodeTail = newNode;
                QueueSize++;
            }
            Console.WriteLine(item);
            }

            public T Dequeue()
            {
                if (NodeTail == null)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                T value = NodeHead.Tvalue;
                NodeHead = NodeHead.NextNode;

                if (NodeHead == null)
                {

                    NodeTail = null;
                }

                QueueSize--;
                return value;
            }

            public int Size()
            {
                return QueueSize;
            }

            public bool IsEmpty()
            {
                return NodeHead == null;
            }

        }

    }



        

   

    



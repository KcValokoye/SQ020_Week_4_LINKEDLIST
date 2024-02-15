using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListMethod<T> : Node<T>
    {
        private int ListSize;

        //Linked List for Add and Size
        public int AddItem(T Rvalue)
        {
            var node = new Node<T> { Tvalue = Rvalue };
            if (NodeHead == null)
            {
                NodeHead = node;
            }
            else
            {
                var currentNode = NodeHead; 
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = node;
            }
            ListSize++;
            return ListSize;
        }

        
        //Linked List Check Method
        public bool Check(T Rvalue)
        { 
            var currentNode = NodeHead;
            while (currentNode != null)
            {
                if (currentNode.Tvalue.Equals(Rvalue))
                {
                    return true;
                }
                currentNode = currentNode.NextNode; 
            }
            return false;
        }


        // Linked List Remove Method
        public bool Remove(T Rvalue)
        { 
            if (NodeHead == null)
            {
                return false;
            }

           
            if (NodeHead.Tvalue.Equals(Rvalue))
            {
                NodeHead = NodeHead.NextNode; 
                return true;
            }

            var currentNode = NodeHead;  

            while (currentNode.NextNode != null && !currentNode.NextNode.Tvalue.Equals(Rvalue)) 
            {
                currentNode.NextNode = currentNode.NextNode.NextNode;
                return true;
            }
            /*if (currentNode.NextNode != null)
            {
                currentNode.NextNode = currentNode.NextNode.NextNode; 
                return true;
            }*/

            return false;
        }


         // LinkedList index Method
        public int IndexOf(T Rvalue)
        { 
            

            var currentNode = NodeHead;  
 
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentNode.Tvalue.Equals(Rvalue))
                {
                    return currentIndex;
                }

                currentNode = currentNode.NextNode; 
                currentIndex++;
            }

            return -1;
        }
    }
}
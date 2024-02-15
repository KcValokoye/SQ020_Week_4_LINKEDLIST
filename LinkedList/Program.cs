using System.Linq;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LinkedList Method
            var linkedList = new LinkedListMethod<int>();
            Console.WriteLine("The result for Add  Size method");
            Console.WriteLine(linkedList.AddItem(2));
            Console.WriteLine(linkedList.AddItem(4));
           
            Console.WriteLine("The result for remove method");
            Console.WriteLine();
            Console.WriteLine(linkedList.Remove(4));
          
            Console.WriteLine("The result for check method");
            Console.WriteLine();
            Console.WriteLine(linkedList.Check(2));
         
            Console.WriteLine("The result for index");
            Console.WriteLine();
            Console.WriteLine(linkedList.IndexOf(2));

            
            //Queue Data Type//         
            Console.WriteLine("The result for Enqueue method");
            var queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(6);
        
            Console.WriteLine("The result for is size method");
            Console.WriteLine();
            Console.WriteLine(queue.Size());
          
            Console.WriteLine("The result for Dequeue method");
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
  
            Console.WriteLine("The result for is empty method");


            //Stack data
            Console.WriteLine("The result for push method");
            var stack = new Stack<int>();
            stack.Push(6);
            stack.Push(8);

            Console.WriteLine("The result for is size method");
            Console.WriteLine();
            Console.WriteLine(stack.Size());

            Console.WriteLine("The result for pop method");
            Console.WriteLine();
            Console.WriteLine(stack.Pop());

            Console.WriteLine("The result for is peek method");
            Console.WriteLine();
            Console.WriteLine(stack.Peek());

            Console.WriteLine("The result for IsEmpty method");
            Console.WriteLine();
            Console.WriteLine(stack.IsEmpty());

        }
    }
}

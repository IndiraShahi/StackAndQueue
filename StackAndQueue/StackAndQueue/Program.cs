using System;
using System.Collections;

namespace StackAndQueue
    {
        public class Program
        {
        public static void Main(String[] args)
        {
            // create Object of Implementing class
            StackUsingLinkedlist obj = new StackUsingLinkedlist();

             // insert Stack value
            obj.push(70);
            obj.push(30);
            obj.push(56);

            // print Stack elements
            obj.display();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.peak());
            // Delete top element of Stack
            obj.pop();
            obj.pop();
            obj.pop();


            // print Stack elements
            obj.display();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.peak());
            {
                QueueUsingLinkedList queue = new QueueUsingLinkedList();
                queue.Enqueue(56);
                queue.Enqueue(30);
                queue.Enqueue(70);
                Console.WriteLine("The elements in queue are");
                queue.Display();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class NodeQ
    {
        public int data;
        public NodeQ next;
    }
    public class QueueUsingLinkedList
    {
        NodeQ top;

        public QueueUsingLinkedList()
        {
            this.top = null;
        }

        public bool isEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }

        public void Enqueue(int data)
        {
            NodeQ node = new NodeQ();
            node.data = data;
            if (isEmpty() == true)
            {
                this.top = node;
                node.next = null;
            }
            else
            {
                NodeQ n = top;

                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }

        public void Dequeue()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Queue is empty");
            }
            if (Size() == 1)
            {
                this.top = null;
            }
            if (Size() > 1)
            {
                NodeQ n = this.top;
                this.top = n.next;
            }
        }

        public void Display()
        {
            NodeQ n = this.top;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }

        public int Size()
        {
            int count = 0;
            NodeQ n = this.top;
            while (n != null)
            {
                count++;
                n = n.next;
            }
            return count;
        }
    }
}
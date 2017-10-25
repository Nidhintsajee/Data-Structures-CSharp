using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice
{
    sealed class MyQueue
    {
        private Node head;
        private Node tail;
        private int size;

        public void push(Node n)
        {
            if (head == null)
            {
                head = tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
            size++;
        }

        public Node pop()
        {
            if (head == null)
            {
                throw new Exception("Queue Empty");
            }
            Node temp = head;
            head = head.next;
            size--;
            if (size == 0) { head = tail = null; }
            temp.next = null;
            return temp;
        }

        public class Node
        {
            private String data;
            public Node next;

            public Node(String data)
            {
                this.data = data;
            }

            public override string ToString()
            {
                return data;
            }
        }

        static void Main(String[] args)
        {
            MyQueue queue = new MyQueue();
            queue.push(new Node("1"));
            queue.push(new Node("2"));
            queue.push(new Node("3"));
            queue.push(new Node("4"));
            queue.push(new Node("5"));
            Console.WriteLine("Deleted: "+queue.pop());
            Console.WriteLine("Deleted: "+queue.pop());
            Console.WriteLine("Deleted: "+queue.pop());
        }
    }

}

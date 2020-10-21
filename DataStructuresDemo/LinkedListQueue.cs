using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    public class LinkedListQueue
    {
        internal Node head = null;
        internal void Enque(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Item Added to Linked List Queue: " + node.data);
        }

        internal void Deque()
        {
            if (head == null)
            {
                Console.WriteLine("No data");
            }
            else
            {
                Console.WriteLine("Deleting : " + head.data);
                head = head.next;
            }
        }

        internal void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No data");
            }
            else
            {
                Console.WriteLine("\nQueue:");
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }
        }

    }
}


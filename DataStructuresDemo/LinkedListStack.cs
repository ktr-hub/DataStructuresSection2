﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    public class LinkedListStack
    {
        internal Node top;

        internal void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine("Item Pushed to Linked List Stack : " + node.data);
        }

        internal void Display()
        {
            if (top == null)
            {
                Console.WriteLine("No data");
            }
            else
            {
                Console.WriteLine("\nStack:");
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        internal int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("No data to show Peek ...");
                return -1;
            }
            return top.data;
        }

        internal void Pop()
        {
            Console.WriteLine("Deleting element : " + top.data);
            top = top.next;
        }
    }
}
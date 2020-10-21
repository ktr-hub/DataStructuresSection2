using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(10);
            linkedListStack.Display();
            linkedListStack.Push(20);
            linkedListStack.Display();
            linkedListStack.Push(30);
            linkedListStack.Display();
        }
    }
}

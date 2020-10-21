using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enque(10);
            linkedListQueue.Enque(20);
            linkedListQueue.Enque(30);
            linkedListQueue.Display();
        }
    }
}

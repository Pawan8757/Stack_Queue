﻿using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List operation");
            LinkedList list = new LinkedList();

            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
﻿using System.Xml.Linq;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> node = new Node<int>();

            node.InsertNode(10);
            node.InsertNode(20);
            node.InsertNode(30);
            node.InsertNode(2);
            node.InsertNode(45);
            node.InsertNode(83);
            node.Display();

            Console.WriteLine();
            if (node.Search(45))
            {
                Console.WriteLine("Element is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }

        }
    }
}
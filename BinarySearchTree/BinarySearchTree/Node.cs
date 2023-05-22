using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable<T>
    {
        T data;
        Node<T> left;
        Node<T> right;

        public Node(T x)
        {
            data = x;
            left = null;
            right = null;
        }

        public Node()
        {

        }
        
        Node<T> root = null;
        
        public void InsertNode(T data)
        {
            root = InsertData(root, data);
        }

        public Node<T> InsertData(Node<T> root, T data) 
        {
            // Insert a new node if tree is empty
            if (root == null)
            {
                root = new Node<T>(data);
            }
            /*
             * If data is less than the root node 
             * then insert the data to left of the root
             * node
             */
            if (data.CompareTo(root.data) < 0)
            {
                root.left = InsertData(root.left, data);
            }
            /*
             * If data is greater than the root node 
             * then insert the data to right of the
             * root node
             */
            else if (data.CompareTo(root.data) > 0)
            {
                root.right = InsertData(root.right, data);

            }
            return root;
        }

        public void Display()
        {
            Console.WriteLine("PREORDER TRAVERSAL");
            PrintPreorder();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("INORDER TRAVERSAL");
            PrintInorder();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("POSTORDER TRAVERSAL");
            PrintPostorder();
            Console.WriteLine();

        }

        public void PrintPreorder()
        {
            PrintPreorder(root);
        }

        private void PrintPreorder(Node<T> root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                PrintPreorder(root.left);
                PrintPreorder(root.right);
                
            }
            
        }

        public void PrintInorder()
        {
            PrintInorder(root);
        }

        private void PrintInorder(Node<T> root)
        {
            if (root != null)
            {
                PrintInorder(root.left);
                Console.Write(root.data + " ");
                PrintInorder(root.right);
            }
        }

        public void PrintPostorder()
        {
            PrintPostorder(root);
        }

        private void PrintPostorder(Node<T> root)
        {
            if (root != null)
            {
                PrintPostorder(root.left);
                PrintPostorder(root.right);
                Console.Write(root.data + " ");
            }
        }
    }
}

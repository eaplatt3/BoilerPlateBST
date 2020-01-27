using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerPlateBST
{
    class BinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public void DisplayNode()
            {
                Console.Write(data + " ");
            }
        }

        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(int i)
        {
            Node newNode = new Node();
            newNode.data = i;
            if(root == null)
            {
                root = newNode;
            }

            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;

                    if(i < current.data)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                }
            }
        }
    }
}

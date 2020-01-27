using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerPlateBST
{
    class BinarySearchTree
    {
        //Creates Nodes on the tree to store data
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            //Display data in a Node
            public void DisplayNode()
            {
                Console.Write(data + " ");
            }
        }

        //Creating the first node in the tree
        public Node root;

        //Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //Method to Insert data into the tree
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

                        else
                        {
                            current = current.right;
                            if(current == null)
                            {
                                parent.right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void PrintAllNodes(Node root)
        {
            if(root != null)
            {
                PrintAllNodes(root.left);
                if(root.left != null && root.right != null)
                {
                    Console.Write(root.data + " ");
                }

                PrintAllNodes(root.right);
            }
        }
    }
}
